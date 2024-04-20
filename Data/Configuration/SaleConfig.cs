using System.Data.Entity.ModelConfiguration;
using StockApp.Data.Entity;

namespace StockApp.Data.Configuration
{
    public class SaleConfig : EntityTypeConfiguration<Sale>
    {

        public SaleConfig()
        {
            ToTable(nameof(Sale));

            HasKey(x=>x.Id);
            HasIndex(x=>x.Id);

            HasRequired(x=>x.Client)
                .WithMany(x=>x.Sales)
                .HasForeignKey(x=>x.ClientId);



        }
    }
}
