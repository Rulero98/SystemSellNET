using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SystemSell.DALL.DBContext;
using SystemSell.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SystemSell.DAL.Implementation
{
    public class GenericRpository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DBVENTAContext _dbContext;
        public GenericRpository(DBVENTAContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<TEntity> Gett(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                TEntity entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
                return entity;
            }
            catch
            {
                throw;
            }
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entity);
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch
            {
                throw;
            }
        }

            public async Task<bool> Update(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Update(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IQueryable<TEntity>> Query(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> queryEntity = filter == null ? _dbContext.Set<TEntity>() : _dbContext.Set<TEntity>().Where(filter);
            return queryEntity;
        }
    }
}
