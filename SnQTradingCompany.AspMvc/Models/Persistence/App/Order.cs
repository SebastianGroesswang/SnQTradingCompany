//@GeneratedCode
namespace SnQTradingCompany.AspMvc.Models.Persistence.App
{
    using System;
    public partial class Order : SnQTradingCompany.Contracts.Persistence.App.IOrder
    {
        static Order()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Order()
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
        public System.DateTime CreatedOn
        {
            get;
            set;
        }
        public System.Int32 Count
        {
            get;
            set;
        }
        public System.Decimal PriceNet
        {
            get;
            set;
        }
        public System.Decimal Discount
        {
            get;
            set;
        }
        public void CopyProperties(SnQTradingCompany.Contracts.Persistence.App.IOrder other)
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
                CreatedOn = other.CreatedOn;
                Count = other.Count;
                PriceNet = other.PriceNet;
                Discount = other.Discount;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQTradingCompany.Contracts.Persistence.App.IOrder other, ref bool handled);
        partial void AfterCopyProperties(SnQTradingCompany.Contracts.Persistence.App.IOrder other);
        public static Persistence.App.Order Create()
        {
            BeforeCreate();
            var result = new Persistence.App.Order();
            AfterCreate(result);
            return result;
        }
        public static Persistence.App.Order Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.App.Order();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.App.Order Create(SnQTradingCompany.Contracts.Persistence.App.IOrder other)
        {
            BeforeCreate(other);
            var result = new Persistence.App.Order();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.App.Order instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.App.Order instance, object other);
        static partial void BeforeCreate(SnQTradingCompany.Contracts.Persistence.App.IOrder other);
        static partial void AfterCreate(Persistence.App.Order instance, SnQTradingCompany.Contracts.Persistence.App.IOrder other);
    }
}
