using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ups.OA.IDAL
{
    public interface IBaseDal<T> where T:class, new()
    {
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamdba);

        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLamdba,
            Expression<Func<T, S>> orderByLamdba, bool isAsc);
        
        T Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);
        
    }
}
