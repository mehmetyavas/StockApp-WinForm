using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockApp.Data.Context;
using StockApp.Data.Entity;

namespace StockApp.Data.Repository
{

    public class ProductRepository:BaseRepository<Product> 
    { }
}
