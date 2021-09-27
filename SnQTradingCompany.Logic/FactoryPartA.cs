//@GeneratedCode
namespace SnQTradingCompany.Logic
{
    public static partial class Factory
    {
        static partial void CreateController<I>(ref Contracts.Client.IControllerAccess<I> controller) where I : Contracts.IIdentifiable
        {
            if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
            {
                controller = new Controllers.Persistence.ItemMaster.CostumerController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                controller = new Controllers.Persistence.ItemMaster.ProductController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
            {
                controller = new Controllers.Persistence.App.ConditionController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
            {
                controller = new Controllers.Persistence.App.OrderController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
        static partial void CreateController<I>(object sharedController, ref Contracts.Client.IControllerAccess<I> controller) where I : Contracts.IIdentifiable
        {
            if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer))
            {
                controller = new Controllers.Persistence.ItemMaster.CostumerController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.ItemMaster.IProduct))
            {
                controller = new Controllers.Persistence.ItemMaster.ProductController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.ICondition))
            {
                controller = new Controllers.Persistence.App.ConditionController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else if (typeof(I) == typeof(SnQTradingCompany.Contracts.Persistence.App.IOrder))
            {
                controller = new Controllers.Persistence.App.OrderController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
            }
            else
            {
                throw new Logic.Modules.Exception.LogicException(Modules.Exception.ErrorType.InvalidControllerType);
            }
        }
    }
}
