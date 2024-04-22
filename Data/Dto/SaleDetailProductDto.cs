using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Utils.CustomAttributes;

namespace StockApp.Data.Dto
{
    public class SaleDetailProductDto
    {


        public long Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string BarcodeNo { get; set; }

        public int Amount { get; set; }


    }
}
