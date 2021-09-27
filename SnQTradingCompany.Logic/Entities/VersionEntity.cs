//@CodeCopy

using SnQTradingCompany.Contracts;

namespace SnQTradingCompany.Logic.Entities
{
	internal abstract partial class VersionEntity : IdentityEntity, IVersionable
	{
		public byte[] RowVersion { get; set; }
	}
}
