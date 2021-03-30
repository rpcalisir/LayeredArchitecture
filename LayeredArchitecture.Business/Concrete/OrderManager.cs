using LayeredArchitecture.Business.Abstract;
using LayeredArchitecture.Business.Constants;
using LayeredArchitecture.Core.Utilities.Results;
using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAll()
        {
            if (DateTime.Now.Hour > 22)
            {
                return new ErrorDataResult<List<Order>>(_orderDal.GetAll(),Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAllByUnitPrice(int min, int max)
        {
            throw new NotImplementedException();
        }
    }
}
