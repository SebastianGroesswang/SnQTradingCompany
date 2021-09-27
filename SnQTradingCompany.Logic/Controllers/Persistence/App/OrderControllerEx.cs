using SnQTradingCompany.Contracts.Persistence.App;
using SnQTradingCompany.Contracts.Persistence.ItemMaster;
using SnQTradingCompany.Logic.Entities.Persistence.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Logic.Controllers.Persistence.App
{
    partial class OrderController
    {
        protected override Order BeforeInsert(Order entity)
        {
            if (entity.Count <= 0)
                throw new Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidEntityContent);

            Task.Run(async () =>
            {
                using var productCtrl = Factory.Create<IProduct>();

                entity.PriceNet = (await productCtrl.GetByIdAsync(entity.ProductId)).Price * entity.Count;
                entity.CreatedOn = DateTime.Now;
                entity.Discount = await CalculateDiscount(entity).ConfigureAwait(false);
                
            }).Wait();

            return base.BeforeInsert(entity);
        }

        protected override Order BeforeUpdate(Order entity)
        {
            if (entity.Count <= 0)
                throw new Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidEntityContent);

            Task.Run(async () =>
            {
                using var productCtrl = Factory.Create<IProduct>();

                entity.PriceNet = (await productCtrl.GetByIdAsync(entity.ProductId)).Price;
                entity.CreatedOn = DateTime.Now;
                entity.Discount = await CalculateDiscount(entity).ConfigureAwait(false);
            }).Wait();

            return base.BeforeUpdate(entity);
        }

        private async Task<decimal> CalculateDiscount(Order entity)
        {
            using var ctrl = Factory.Create<ICondition>();

            //get only the appropriate conditions
            //var allConditions = (await ctrl.GetAllAsync()).Where(item => item.CostumerId == entity.CostumerId && item.ProductId == entity.ProductId);

            var allConditions = await ctrl.QueryAllAsync($"{nameof(entity.CostumerId)} = {entity.CostumerId} and {nameof(entity.ProductId)} = {entity.ProductId}");
            var listOfPossiblePrices = new List<decimal>() { 0 };

            foreach (var item in allConditions)
            {
                if (item.ConditionType == Contracts.Modules.Common.ConditionTypeEnum.PieceDiscountRelative)
                {
                    if(entity.Count > item.Quantity)
                    {
                        listOfPossiblePrices.Add(entity.PriceNet * (item.Value / 100));
                    }
                }
                else if (item.ConditionType == Contracts.Modules.Common.ConditionTypeEnum.PieveDiscountAbsolute)
                {
                    if(entity.Count > item.Quantity)
                    {
                        listOfPossiblePrices.Add(item.Value);
                    }
                }
                else if (item.ConditionType == Contracts.Modules.Common.ConditionTypeEnum.ValueDiscountRelative)
                {
                    if (Convert.ToDouble(entity.PriceNet) > item.Quantity)
                    {
                        listOfPossiblePrices.Add(entity.PriceNet * (item.Value / 100));
                    }
                }
                else if (item.ConditionType == Contracts.Modules.Common.ConditionTypeEnum.ValueDiscountAbsolute)
                {
                    if (Convert.ToDouble(entity.PriceNet) > item.Quantity)
                    {
                        listOfPossiblePrices.Add(item.Value);
                    }
                }
            }

            return listOfPossiblePrices.Max();
        }
    }
}
