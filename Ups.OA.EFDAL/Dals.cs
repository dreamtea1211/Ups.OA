 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.IDAL;
using Ups.OA.Model;

namespace Ups.OA.EFDAL
{
	public partial class CustomerDal : BaseDal<Customer>,ICustomerDal
	{
	}
	public partial class OrderInfoDal : BaseDal<OrderInfo>,IOrderInfoDal
	{
	}
	public partial class ProductDal : BaseDal<Product>,IProductDal
	{
	}
	public partial class R_Customer_RoleInfoDal : BaseDal<R_Customer_RoleInfo>,IR_Customer_RoleInfoDal
	{
	}
	public partial class RoleInfoDal : BaseDal<RoleInfo>,IRoleInfoDal
	{
	}
 


}