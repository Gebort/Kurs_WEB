using CW.Shared.Model;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CW.Server.Model {

    public class ApplicationContext : ApiAuthorizationDbContext<User> {

        public DbSet<Writing> Writings { get; set; } = null!;

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlServer(Startup.DbConfigurationString);
        //}

        public ApplicationContext(DbContextOptions<ApplicationContext> options,
                                  IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) {
            Database.EnsureCreated();
        }

    }
}
