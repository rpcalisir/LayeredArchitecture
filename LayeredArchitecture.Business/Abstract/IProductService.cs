using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByUnitPrice(int min, int max);
        List<ProductDetailsDto> GetProductDetails();
    }
}
