using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.Entity
{
    public class Sale:BaseEntity
    {
        public Guid ClientId { get; set; }


        public decimal Total { get; set; }
        public Client Client { get; set; }

        public ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}
