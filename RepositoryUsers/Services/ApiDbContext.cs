
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RepositoryUsers.Models;

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

        public virtual DbSet<UserModel> Users => Set<UserModel>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("ApiDbConString");
            options.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasKey(a => new { a.Id });
        }

    }
}
