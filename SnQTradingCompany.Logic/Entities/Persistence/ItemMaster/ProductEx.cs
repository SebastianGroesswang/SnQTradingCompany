using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Logic.Entities.Persistence.ItemMaster
{
    partial class Product
    {
        public override string ToString()
        {
            return $"{Name}--{Number}--{Price}";
        }
    }
}
