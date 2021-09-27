//@CodeCopy

namespace SnQTradingCompany.Contracts
{
	public partial interface ICopyable<T>
	{
		void CopyProperties(T other);
	}
}
