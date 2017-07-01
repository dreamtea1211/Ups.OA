 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.Model;

namespace Ups.OA.IDAL
{
	public partial interface ICustomerDal:IBaseDal<Customer>
	{
	}
	public partial interface IOrderInfoDal:IBaseDal<OrderInfo>
	{
	}
	public partial interface IProductDal:IBaseDal<Product>
	{
	}
	public partial interface IR_Customer_RoleInfoDal:IBaseDal<R_Customer_RoleInfo>
	{
	}
	public partial interface IRoleInfoDal:IBaseDal<RoleInfo>
	{
	}
 


}