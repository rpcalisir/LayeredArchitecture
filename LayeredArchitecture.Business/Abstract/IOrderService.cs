using LayeredArchitecture.Core.Utilities.Results;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetAllByCategoryId(int id);
        IDataResult<List<Order>> GetAllByUnitPrice(int min, int max);
    }
}
