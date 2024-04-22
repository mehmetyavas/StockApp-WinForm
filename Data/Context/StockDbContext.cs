using System.Data.Entity;
using StockApp.Data.Configuration;
using StockApp.Data.Entity;

namespace StockApp.Data.Context
{
    public class StockDbContext : DbContext
    {
        private const string ConnStr = "Server=DESKTOP-MMGGSL3;Initial Catalog=StockAppDev;TrustServerCertificate=True;Integrated Security=True";
        public StockDbContext() : base(ConnStr)
        {
            Database.Connection.ConnectionString = ConnStr;
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new ProductConfig());
            modelBuilder.Configurations.Add(new SaleConfig());
            modelBuilder.Configurations.Add(new SaleDetailConfig());
        }

    }
}

