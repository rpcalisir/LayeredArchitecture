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
        void Add(Order order);
        List<Order> GetAll();
        List<Order> GetAllByCategoryId(int id);
        List<Order> GetAllByUnitPrice(int min, int max);
    }
}
