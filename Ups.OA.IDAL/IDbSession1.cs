 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.Model;

namespace Ups.OA.IDAL
{
	public partial interface IDbSession
	{
		ICustomerDal CustomerDal { get; }
		IOrderInfoDal OrderInfoDal { get; }
		IProductDal ProductDal { get; }
		IR_Customer_RoleInfoDal R_Customer_RoleInfoDal { get; }
		IRoleInfoDal RoleInfoDal { get; }
	 

	}
}