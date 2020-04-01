using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SimpleApiAuthRegUser.Entities;

namespace SimpleApiAuthRegUser.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mariadb server database
            options.UseMySql(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}