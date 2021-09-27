//@GeneratedCode
namespace SnQTradingCompany.AspMvc.Models.Persistence.ItemMaster
{
    using System;
    public partial class Costumer : SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer
    {
        static Costumer()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        public Costumer()
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        public System.String Number
        {
            get;
            set;
        }
        public System.String Name
        {
            get;
            set;
        }
        public void CopyProperties(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other)
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
                Number = other.Number;
                Name = other.Name;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other, ref bool handled);
        partial void AfterCopyProperties(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other);
        public static Persistence.ItemMaster.Costumer Create()
        {
            BeforeCreate();
            var result = new Persistence.ItemMaster.Costumer();
            AfterCreate(result);
            return result;
        }
        public static Persistence.ItemMaster.Costumer Create(object other)
        {
            BeforeCreate(other);
            CommonBase.Extensions.ObjectExtensions.CheckArgument(other, nameof(other));
            var result = new Persistence.ItemMaster.Costumer();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        public static Persistence.ItemMaster.Costumer Create(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other)
        {
            BeforeCreate(other);
            var result = new Persistence.ItemMaster.Costumer();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(Persistence.ItemMaster.Costumer instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(Persistence.ItemMaster.Costumer instance, object other);
        static partial void BeforeCreate(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other);
        static partial void AfterCreate(Persistence.ItemMaster.Costumer instance, SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer other);
    }
}
