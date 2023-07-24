using Microsoft.EntityFrameworkCore;

namespace demo_webapi_dotnet_1.Data
{
    public class FoodDeliveryDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public FoodDeliveryDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Drivers> Drivers { get; set; }

        public DbSet<Foods> Foods { get; set; }

        public DbSet<Merchants> Merchants { get; set; }

        public DbSet<OrderItems> OrderItems { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Payments> Payment { get; set; }

    }
}

