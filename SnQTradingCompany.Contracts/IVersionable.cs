//@CodeCopy

namespace SnQTradingCompany.Contracts
{
	public partial interface IVersionable : IIdentifiable
	{
		byte[] RowVersion { get; }
	}
}
