//@GeneratedCode
namespace SnQTradingCompany.Logic.Controllers.Persistence.App
{
    sealed partial class ConditionController : GenericPersistenceController<SnQTradingCompany.Contracts.Persistence.App.ICondition, Entities.Persistence.App.Condition>
    {
        static ConditionController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        internal ConditionController(DataContext.IContext context):base(context)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        internal ConditionController(ControllerObject controller):base(controller)
        {
            Constructing();
            Constructed();
        }
    }
}
