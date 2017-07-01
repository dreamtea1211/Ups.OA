using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.Model;

namespace Ups.OA.EFDAL
{
    /// <summary>
    /// 职责:封装所有dal的公共crud方法
    /// 类的职责一定要单一
    /// </summary>
    public class BaseDal<T> where T : class,new()
    {
        public DbContext Db
        {
            get { return DbContextFactory.GetCurrentDbContext(); }
        }
        public IQueryable<T> GetEntities(Expression<Func<T,bool>> whereLamdba)
        {
            return Db.Set<T>().Where(whereLamdba).AsQueryable();
        }

        public IQueryable<T> GetPageEntities<S>(int pageSize,int pageIndex,out int total,Expression<Func<T,bool>> whereLamdba,
            Expression<Func<T,S>> orderByLamdba,bool isAsc)
        {
            total = Db.Set<T>().Where(whereLamdba).Count();

            if(isAsc)
            {
                var temp = Db.Set<T>().Where(whereLamdba)
                    .OrderBy<T,S>(orderByLamdba)
                    .Skip(pageSize*(pageIndex-1))
                    .Take(pageSize).AsQueryable();

                return temp;
            }
            else
            {
                var temp = Db.Set<T>().Where(whereLamdba)
                    .OrderByDescending<T,S>(orderByLamdba)
                    .Skip(pageSize*(pageIndex-1))
                    .Take(pageSize).AsQueryable();

                return temp;
            }
        }

        public T Add(T entity)
        {
            Db.Set<T>().Add(entity);
            //Db.SaveChanges();
            //return entity;
            return entity;
        }

        public bool Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            //return Db.SaveChanges() > 0;
            return true;
        }

        public bool Delete(T entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;
            //return Db.SaveChanges() > 0;
            return true;
        }
    }
}
