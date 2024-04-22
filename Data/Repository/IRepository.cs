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
    public interface IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
         
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> func = null);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> func);

        Task AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }

 
}
                                                                                                                                    