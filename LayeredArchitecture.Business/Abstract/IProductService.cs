using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business.Abstract
{
    public interface IProductService : IEntityService
    {
        void Add(Product product);
        List<Product> GetAll();
    }
}
