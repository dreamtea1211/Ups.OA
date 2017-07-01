 
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
	public ICustomerDal CustomerDal
    {
        get { return StaticFactory.GetCustomerDal(); }
    }
	public IOrderInfoDal OrderInfoDal
    {
        get { return StaticFactory.GetOrderInfoDal(); }
    }
	public IProductDal ProductDal
    {
        get { return StaticFactory.GetProductDal(); }
    }
	public IR_Customer_RoleInfoDal R_Customer_RoleInfoDal
    {
        get { return StaticFactory.GetR_Customer_RoleInfoDal(); }
    }
	public IRoleInfoDal RoleInfoDal
    {
        get { return StaticFactory.GetRoleInfoDal(); }
    }
 

	}
}