using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.Entity
{
    public interface IEntity
    {

         DateTime CreatedAt { get; set; }
         DateTime? ModifiedAt { get; set; }
    }
}
