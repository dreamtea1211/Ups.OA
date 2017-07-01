using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.DALFactory;
using Ups.OA.IDAL;

namespace Ups.OA.BLL
{
    /// <summary>
    /// 父类要逼迫自己给父类的一个属性赋值
    /// 赋值的操作必须在父类的方法调用之前执行
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseServic<T> where T:class,new()
    {
        public IBaseDal<T> CurrentDal { get; set; }
        public IDbSession DbSession 
        {
            get;
            set;
            //get 
            //{ 
            //    return DbSessionFactory.GetCurrentDbSession(); 
            //}
        } 
        //public BaseServic(IDbSession dbSession)
        //{
        //    DbSession = dbSession;
        //    SetCurrentDal();
        //}
        //public abstract void SetCurrentDal();//抽象方法:要求子类必须实现

        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLamdba)
        {
            return CurrentDal.GetEntities(whereLamdba);
        }

        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLamdba,
            Expression<Func<T, S>> orderByLamdba, bool isAsc)
        {
            return CurrentDal.GetPageEntities(pageSize, pageIndex, out total, whereLamdba, orderByLamdba, isAsc);
        }

        public T Add(T entity)
        {
            CurrentDal.Add(entity);
            DbSession.SaveChanges();
            return entity;
        }

        public bool Update(T entity)
        {
            CurrentDal.Update(entity);
            return DbSession.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return DbSession.SaveChanges() > 0;
        }
    }
}
