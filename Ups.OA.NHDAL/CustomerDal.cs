using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ups.OA.IDAL;

namespace Ups.OA.NHDAL
{
    public class CustomerDal : ICustomerDal
    {

        public IQueryable<Ups.OA.Model.Customer> GetEntities(System.Linq.Expressions.Expression<Func<Ups.OA.Model.Customer, bool>> whereLamdba)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Ups.OA.Model.Customer> GetPageEntities<S>(int pageSize, int pageIndex, out int total, System.Linq.Expressions.Expression<Func<Ups.OA.Model.Customer, bool>> whereLamdba, System.Linq.Expressions.Expression<Func<Ups.OA.Model.Customer, S>> orderByLamdba, bool isAsc)
        {
            throw new NotImplementedException();
        }

        public Ups.OA.Model.Customer Add(Ups.OA.Model.Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ups.OA.Model.Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Ups.OA.Model.Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
