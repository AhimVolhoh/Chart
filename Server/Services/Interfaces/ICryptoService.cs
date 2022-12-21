using Template.Shared.Models;

namespace Template.Server.Services.Interfaces
{
	public interface ICryptoServices
	{
		Task Add(CryptoDate CryptoTimeDate);
		Task Delete(int id);
		Task <List<CryptoDate>>GetList();
	}
}
