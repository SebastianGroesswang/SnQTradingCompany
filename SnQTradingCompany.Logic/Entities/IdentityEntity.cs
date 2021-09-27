//@CodeCopy
//MdStart
using SnQTradingCompany.Contracts;

namespace SnQTradingCompany.Logic.Entities
{
    internal abstract partial class IdentityEntity : EntityObject, IIdentifiable
	{
		public int Id { get; set; }
    }
}
//MdEnd
