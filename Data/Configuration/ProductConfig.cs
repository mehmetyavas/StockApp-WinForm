using System.Data.Entity.ModelConfiguration;
using StockApp.Data.Entity;

namespace StockApp.Data.Configuration
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {

        public ProductConfig() 
        {
            ToTable(nameof(Product));
            HasKey(x => x.Id);
            HasIndex(x => x.Id);
            HasIndex(x => x.BarcodeNo);
            HasIndex(x => x.Name);


        }
    }
}
