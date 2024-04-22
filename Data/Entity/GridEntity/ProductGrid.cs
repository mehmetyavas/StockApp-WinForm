using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Utils.CustomAttributes;

namespace StockApp.Data.Entity
{
    public class ProductGrid:BaseEntity<Guid>
    {

        public ProductGrid(Product product) 
        {
            Id=product.Id;
            Name =product.Name;
            Description =product.Description;
            StockAmount = product.StockAmount;
            Price = product.Price;
            BarcodeNo = product.BarcodeNo;
            Adet = 1;
            CreatedAt = product.CreatedAt;
            ModifiedAt = product.ModifiedAt;
        
        
        }
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(150)]
        public string Description { get; set; }
        [PositiveNumber]
        public int StockAmount { get; set; }
        [PositiveNumber]
        public decimal Price { get; set; }

        [Required, MaxLength(20)]
        public string BarcodeNo { get; set; }
        [PositiveNumber]
        public int Adet { get; set; }


    }
}
