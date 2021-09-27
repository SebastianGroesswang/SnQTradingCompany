//@GeneratedCode
namespace SnQTradingCompany.Adapters
{
    public static partial class Factory
    {
        public static Contracts.Client.IAdapterAccess<I> Create<I>()
        {
            Contracts.Client.IAdapterAccess<I> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.App.ICondition>() as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.App.IOrder>() as Contracts.Client.IAdapterAccess<I>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer, Transfer.Models.Persistence.ItemMaster.Costumer>(BaseUri, "Costumers") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct, Transfer.Models.Persistence.ItemMaster.Product>(BaseUri, "Products") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.App.ICondition, Transfer.Models.Persistence.App.Condition>(BaseUri, "Conditions") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.App.IOrder, Transfer.Models.Persistence.App.Order>(BaseUri, "Orders") as Contracts.Client.IAdapterAccess<I>;
                }
            }
            return result;
        }
        public static Contracts.Client.IAdapterAccess<I> Create<I>(string sessionToken)
        {
            Contracts.Client.IAdapterAccess<I> result = null;
            if (Adapter == AdapterType.Controller)
            {
                if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.App.ICondition>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Controller.GenericControllerAdapter<SnQTradingCompany.Contracts.Persistence.App.IOrder>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
                }
            }
            else if (Adapter == AdapterType.Service)
            {
                if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer, Transfer.Models.Persistence.ItemMaster.Costumer>(sessionToken, BaseUri, "Costumers") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct, Transfer.Models.Persistence.ItemMaster.Product>(sessionToken, BaseUri, "Products") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.App.ICondition, Transfer.Models.Persistence.App.Condition>(sessionToken, BaseUri, "Conditions") as Contracts.Client.IAdapterAccess<I>;
                }
                else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
                {
                    result = new Service.GenericServiceAdapter<SnQTradingCompany.Contracts.Persistence.App.IOrder, Transfer.Models.Persistence.App.Order>(sessionToken, BaseUri, "Orders") as Contracts.Client.IAdapterAccess<I>;
                }
            }
            return result;
        }
    }
}
