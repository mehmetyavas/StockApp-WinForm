using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.Entity
{
    public class SaleDetail : BaseEntity
    {
        public long SaleId { get; set; }
        public Guid ProductId { get; set; }


        public int Amount { get; set; }
        public Sale Sale { get; set; }

        public Product Product { get; set; }
    }
}
