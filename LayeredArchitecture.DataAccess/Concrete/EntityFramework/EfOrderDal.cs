using LayeredArchitecture.Core.DataAccess.Abstract;
using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityDalBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
