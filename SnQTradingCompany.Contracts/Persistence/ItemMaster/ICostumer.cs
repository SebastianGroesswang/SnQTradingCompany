using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Contracts.Persistence.ItemMaster
{
    public interface ICostumer : IVersionable, ICopyable<ICostumer>
    {
        [ContractPropertyInfo(Required =true, MaxLength =8)]
        string Number { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string Name { get; set; }
    }
}
