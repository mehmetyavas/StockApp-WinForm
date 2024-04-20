using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Data.Entity;

namespace StockApp.Data.Configuration
{

    public class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig() {

            ToTable(nameof(Client));

            HasKey(x => x.Id);
            HasIndex(x => x.Id);
            HasIndex(x => x.Email);


        }
        
    }
}
