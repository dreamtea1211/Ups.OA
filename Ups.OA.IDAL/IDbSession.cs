using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ups.OA.IDAL
{
    public partial interface IDbSession
    {
        #region 改成了模版自动生成
        //ICustomerDal CustomerDal { get; }
        //IProductDal ProductDal { get; }
        #endregion

        int SaveChanges();
    }
}
