using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockApp.Data.Context;
using StockApp.Data.Entity;

namespace StockApp.Data.Repository
{

    public class ProductRepository:BaseRepository<Product> 
    {

        public async Task UpdateProductStockAmountProc(long saleId) 
        {
            using (var context= new StockDbContext())
            {

                var result = await context.Database.ExecuteSqlCommandAsync("EXEC CreateSale @SaleId",
                    new SqlParameter("@SaleId", saleId)
                );
            }

        }
    
    
    }
}
