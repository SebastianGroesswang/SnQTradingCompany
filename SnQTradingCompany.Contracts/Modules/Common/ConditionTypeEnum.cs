using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnQTradingCompany.Contracts.Modules.Common
{
    public enum ConditionTypeEnum : int
    {
        PieceDiscountRelative = 0,
        PieveDiscountAbsolute = 1,
        ValueDiscountRelative = 2,
        ValueDiscountAbsolute = 3
    }
}
