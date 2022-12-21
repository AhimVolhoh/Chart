using System.Net.Http.Json;
using Template.Client.ClientServices.Interfaces;
using Template.Shared.Models;

namespace Template.Client.ClientServices
{
	public class CryptoClientService : ICryptoClientService
	{
		private readonly HttpClient _httpClient;

		public CryptoClientService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public CryptoDate SingleCrypto { get; set; } = new();
		public List<CryptoDate> CryptoDates { get; set; } = new();

		public async Task<List<CryptoDate>> GetAllCrypto()
		{
			var result = await _httpClient.GetFromJsonAsync<List<CryptoDate>>("/api/crypto");
			CryptoDates = result;
			return CryptoDates;
		}

		public async Task DeleteCrypto(int id)
		{
			await _httpClient.PostAsJsonAsync("/api/crypto/delete", id);
		}

		public async Task AddCrypto(CryptoDate cryptoDate)
		{
			await _httpClient.PostAsJsonAsync("/api/crypto", cryptoDate);
		}
	}
}
