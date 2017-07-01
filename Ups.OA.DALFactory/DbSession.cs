using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using Ups.OA.EFDAL;
using Ups.OA.IDAL;

namespace Ups.OA.DALFactory
{
    public partial class DbSession:IDbSession
    {
        #region 简单工厂或抽象工厂
        //public ICustomerDal CustomerDal
        //{
        //    get { return StaticFactory.GetCustomerDal(); }
        //}

        //public IProductDal ProductDal
        //{
        //    get { return StaticFactory.GetProductDal(); }
        //}
        #endregion

        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
    }
}
