using Template.Shared.Models;

namespace Template.Client.ClientServices.Interfaces
{
	public interface ICryptoClientService
	{
		Task AddCrypto(CryptoDate CryptoTimeDate);
		Task DeleteCrypto(int id);
		Task<List<CryptoDate>> GetAllCrypto();
	}
}
