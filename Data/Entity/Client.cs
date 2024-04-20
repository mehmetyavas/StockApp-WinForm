using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.Entity
{
    public class Client:BaseEntity<Guid>
    {

        [Required,MaxLength(30)]
        public string FirstName { get; set; }
        [Required,MaxLength(20)]
        public string LastName { get; set; }
        [Required,MaxLength(50)]
        public string Email { get; set; }
        [Required,MinLength(10),MaxLength(10)]
        public string Phone { get; set; }


        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }
}
