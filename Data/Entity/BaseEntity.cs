using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.Entity
{
    public class BaseEntity<T>: IEntity
    {

        public T Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ModifiedAt { get; set; }
    }
    public class BaseEntity : BaseEntity<long>
    {

    }
}
