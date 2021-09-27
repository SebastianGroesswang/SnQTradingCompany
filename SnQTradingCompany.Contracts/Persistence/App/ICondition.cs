using SnQTradingCompany.Contracts.Modules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Contracts.Persistence.App
{
    public interface ICondition : IVersionable, ICopyable<ICondition>
    {
        int ProductId { get; set; }
        int CostumerId { get; set; }
        ConditionTypeEnum ConditionType { get; set; }
        double Quantity { get; set; }
        decimal Value { get; set; }
    }
}
