using LayeredArchitecture.Core.Utilities.Results;
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
        IResult Add(Product product);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(int min, int max);
        IDataResult<List<ProductDetailsDto>> GetProductDetails();
    }
}
