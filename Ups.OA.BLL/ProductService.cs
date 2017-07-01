using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.DALFactory;
using Ups.OA.EFDAL;
using Ups.OA.IDAL;
using Ups.OA.Model;

namespace Ups.OA.BLL
{
    public class ProductService : BaseServic<Product>
    {
        //public ProductService(IDbSession dbSession)
        //    :base(dbSession)
        //{
        //    //this.DbSession = dbSession;
        //}
        //public override void SetCurrentDal()
        //{
        //    CurrentDal = this.DbSession.ProductDal;
        //}
    }
}
