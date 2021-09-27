using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Contracts.Persistence.App
{
    public interface IOrder: IVersionable, ICopyable<IOrder>
    {
        int ProductId { get; set; }
        int CostumerId { get; set; }
        DateTime CreatedOn { get; }
        int Count { get; set; }
        decimal PriceNet { get; }
        decimal Discount { get; }
    }
}
