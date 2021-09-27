using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Contracts.Persistence.ItemMaster
{
    public interface IProduct: IVersionable, ICopyable<IProduct>
    {
        [ContractPropertyInfo(Required = true, MaxLength =256)]
        string Name { get; set; }
        [ContractPropertyInfo(Required =true, MaxLength =256, IsUnique =true)]
        string Number { get; set; }
        [ContractPropertyInfo(Required =true)]
        decimal Price { get; set; }
    }
}
