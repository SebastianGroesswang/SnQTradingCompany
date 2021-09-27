//@GeneratedCode
namespace SnQTradingCompany.Logic.Controllers.Persistence.App
{
    sealed partial class OrderController : GenericPersistenceController<SnQTradingCompany.Contracts.Persistence.App.IOrder, Entities.Persistence.App.Order>
    {
        static OrderController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal OrderController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal OrderController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
