using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using StockApp.Data.Context;
using StockApp.Data.Entity;

namespace StockApp.Data.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new StockDbContext())
            {

                context.Set<TEntity>().Add(entity);

                await context.SaveChangesAsync();

            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new StockDbContext())
            {


                entity.ModifiedAt = DateTime.Now;

                context.Set<TEntity>().AddOrUpdate(entity);

                await context.SaveChangesAsync();

            }
        }
        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new StockDbContext())
            {

                context.Set<TEntity>().Attach(entity);

                context.Set<TEntity>().Remove(entity);
                await context.SaveChangesAsync();

            }
        }
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> func = null)
        {
            using (var context = new StockDbContext())
            {
                return func == null
                ? await context.Set<TEntity>().AsQueryable().ToListAsync()
                    : await context.Set<TEntity>().AsQueryable().Where(func).ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> func)
        {
            using (var context = new StockDbContext())
            {
                return await context.Set<TEntity>().AsQueryable().SingleAsync(func);
            }
        }
    }
}
