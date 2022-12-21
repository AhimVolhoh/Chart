using Microsoft.EntityFrameworkCore;
using Template.Server.Data;
using Template.Server.Services.Interfaces;
using Template.Shared.Models;


namespace Template.Server.Services
{
	public class CryptoService : ICryptoServices
	{
		private readonly ApplicationDbContext _context;
		public CryptoService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task Add(CryptoDate CryptoTimeDate)
		{
			try
			{
				_context.CryptoDates.Add(CryptoTimeDate);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{

				throw new ArgumentException(ex.Message);
			}
			
		}

		public async Task Delete(int id)
		{
			var date = await _context.CryptoDates.ToListAsync();
			var toBeDeleted = date.Find(date=> date.CryptoDateId == id);
			if (toBeDeleted != null)
			{
				_context.Remove(toBeDeleted);
			}
			await _context.SaveChangesAsync();
		}

		public async Task<List<CryptoDate>> GetList()
		{
			var ShowList = await _context.CryptoDates.ToListAsync();
			return ShowList;
		}
	}
}
