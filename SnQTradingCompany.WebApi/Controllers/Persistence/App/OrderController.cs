//@GeneratedCode
namespace SnQTradingCompany.WebApi.Controllers.Persistence.App
{
    using Microsoft.AspNetCore.Mvc;
    using TContract = Contracts.Persistence.App.IOrder;
    using TModel = Transfer.Models.Persistence.App.Order;
    [ApiController]
    [Route("Controller")]
    public partial class OrdersController : WebApi.Controllers.GenericController<TContract, TModel>
    {
    }
}
