//@GeneratedCode
namespace SnQTradingCompany.Logic.Controllers.Persistence.ItemMaster
{
    sealed partial class CostumerController : GenericPersistenceController<SnQTradingCompany.Contracts.Persistence.ItemMaster.ICostumer, Entities.Persistence.ItemMaster.Costumer>
    {
        static CostumerController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal CostumerController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal CostumerController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
