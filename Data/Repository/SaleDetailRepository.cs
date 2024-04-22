using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using StockApp.Data.Context;
using StockApp.Data.Dto;
using StockApp.Data.Entity;

namespace StockApp.Data.Repository
{
    public class SaleDetailRepository : BaseRepository<SaleDetail>
    {


        public async Task<List<SaleDetailProductDto>> GetSaleDetailsForGrid(long saleId)
        {

            using (var context = new StockDbContext())
            {
                var result = await context.SaleDetails
                    .Include(nameof(Product))
                    .Where(x => x.SaleId == saleId)
                    .Select(s => new SaleDetailProductDto
                    {
                        Amount = s.Amount,
                        BarcodeNo = s.Product.BarcodeNo,
                        Id = s.Id,
                        ProductId = s.ProductId,
                        Name = s.Product.Name,
                        Price = s.Product.Price
                    })
                    .ToListAsync();

                return result;

            }


        }
    }

}
