using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Implementation.Activity;
using Repository.Implementation.User;

namespace Repository.Core
{
    public class MyDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyDbContext(IConfiguration configuration) => Configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {            
            options.UseSqlServer(Configuration.GetConnectionString("LoymarkDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
