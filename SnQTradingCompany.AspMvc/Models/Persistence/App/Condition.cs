//@GeneratedCode
namespace SnQTradingCompany.AspMvc.Models.Persistence.App
{
    using System;
    public partial class Condition : SnQTradingCompany.Contracts.Persistence.App.ICondition
    {
        static Condition()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Condition()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.Int32 ProductId
        {
            get;
            set;
        }
        public System.Int32 CostumerId
        {
            get;
            set;
        }
        public SnQTradingCompany.Contracts.Modules.Common.ConditionTypeEnum ConditionType
        {
            get;
            set;
        }
        public System.Double Quantity
        {
            get;
            set;
        }
        public System.Decimal Value
        {
            get;
            set;
        }
        public void CopyProperties(SnQTradingCompany.Contracts.Persistence.App.ICondition other)
        {
            if (other == null)
            {
                throw new System.ArgumentNullException(nameof(other));
            }
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Id = other.Id;
                RowVersion = other.RowVersion;
                ProductId = other.ProductId;
                CostumerId = other.CostumerId;
                ConditionType = other.ConditionType;
                Quantity = other.Quantity;
                Value = other.Value;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQTradingCompany.Contracts.Persistence.App.ICondition other, ref bool handled);
        partial void AfterCopyProperties(SnQTradingCompany.Contracts.Persistence.App.ICondition other);
        public static Persistence.App.Condition Create()
        {
            BeforeCreate();
            var result = new Persistence.App.Condition();
            AfterCreate(result);
            return result;
        }
        public static Persistence.App.Condition Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.App.Condition();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.App.Condition Create(SnQTradingCompany.Contracts.Persistence.App.ICondition other)
        {
            BeforeCreate(other);
            var result = new Persistence.App.Condition();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.App.Condition instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.App.Condition instance, object other);
        static partial void BeforeCreate(SnQTradingCompany.Contracts.Persistence.App.ICondition other);
        static partial void AfterCreate(Persistence.App.Condition instance, SnQTradingCompany.Contracts.Persistence.App.ICondition other);
    }
}
