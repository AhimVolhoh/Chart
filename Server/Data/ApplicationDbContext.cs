using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Template.Server.Models;
using Template.Shared.Models;

namespace Template.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}
		public DbSet<CryptoDate> CryptoDates { get; set; }

		protected override void OnModelCreating(ModelBuilder Builder)
		{
			base.OnModelCreating(Builder);   ///Delaet spiskom vse dannie kotorie prinimaet
		}
	}
}