using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.EFDAL;
using Ups.OA.IDAL;

namespace Ups.OA.DALFactory
{
    public partial class StaticFactory
    {
        private static string assemblyName = System.Configuration.ConfigurationManager.AppSettings["DalAssemblyName"];
        public static ICustomerDal GetCustomerDal()
        {
            //return new CustomerDal();
            return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".CustomerDal") as ICustomerDal;
        }

        public static IProductDal GetProductDal()
        {
            return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".ProductDal") as IProductDal;
        }
    }
}
