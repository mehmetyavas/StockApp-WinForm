using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Utils.CustomAttributes;
using StockApp.Utils.Extensions;

namespace StockApp.Data.Entity
{
    public class Product : BaseEntity<Guid>
    {

      

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(150)]
        public string Description { get; set; }
        [PositiveNumber]
        public int StockAmount { get; set; }
        [PositiveNumber]
        public decimal Price { get; set; }

        [Required,MaxLength(20)]
        public string BarcodeNo { get; set; }

        public ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();

    }
}
