using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;


namespace SystemSell.DAL.Interfaces
{
    internal interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Gett(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> Create(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(TEntity entity);
        Task<IQueryable<TEntity>> Query(Expression<Func<TEntity, bool>> filter = null);

    }
}
