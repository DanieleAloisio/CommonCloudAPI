
using CommonCloud.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RepositoryUsers.Services
{
    public class ApiDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ApiDbContext(DbContextOptions<ApiDbContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public DbSet<AccountReteModel> VW_AccountRete { get; set; }

        public virtual DbSet<UserModel> AR => Set<UserModel>();
        public virtual DbSet<LogModel> Log => Set<LogModel>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("ApiDbConString");
            options.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasKey(a => new { a.Matricola });

            modelBuilder.Entity<LogModel>()
                .HasKey(a => new { a.Id });

            modelBuilder
                .Entity<AccountReteModel>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("VW_AccountRete");
                    });
        }

    }
}
