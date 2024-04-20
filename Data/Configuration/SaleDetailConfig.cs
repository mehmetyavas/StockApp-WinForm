using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Data.Entity;

namespace StockApp.Data.Configuration
{
    public class SaleDetailConfig:EntityTypeConfiguration<SaleDetail>
    {
        public SaleDetailConfig()
        {
            ToTable(nameof(SaleDetail));
            HasKey(x => x.Id);
            HasIndex(x => x.Id);

            HasRequired(x => x.Product)
                .WithMany(x => x.SaleDetails)
                .HasForeignKey(f => f.ProductId);

            HasRequired(x => x.Sale)
                .WithMany(m => m.SaleDetails)
                .HasForeignKey(f => f.SaleId);
        }
    }
}
