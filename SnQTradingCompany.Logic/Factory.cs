//@CodeCopy
using ClientContracts = SnQTradingCompany.Contracts.Client;

namespace SnQTradingCompany.Logic
{
    public static partial class Factory
    {
        private static DataContext.IContext CreateContext()
        {
            return new DataContext.SnQTradingCompanyDbContext();
        }

        public static ClientContracts.IControllerAccess<C> Create<C>()
            where C : SnQTradingCompany.Contracts.IIdentifiable
        {
            var result = default(ClientContracts.IControllerAccess<C>);

            CreateController(ref result);
            return result;
        }
        public static ClientContracts.IControllerAccess<C> Create<C>(object controllerObject)
            where C : SnQTradingCompany.Contracts.IIdentifiable
        {
            var result = default(ClientContracts.IControllerAccess<C>);

            CreateController(controllerObject, ref result);
            return result;
        }
        static partial void CreateController<C>(ref ClientContracts.IControllerAccess<C> controller)
            where C : SnQTradingCompany.Contracts.IIdentifiable;
        static partial void CreateController<C>(object controllerObject, ref ClientContracts.IControllerAccess<C> controller)
            where C : SnQTradingCompany.Contracts.IIdentifiable;
    }
}
