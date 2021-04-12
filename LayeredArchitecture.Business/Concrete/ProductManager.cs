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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour > 22)
            {
                return new ErrorDataResult<List<Product>>(_productDal.GetAll(), Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryID == id));
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailsDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour > 22)
            {
                return new ErrorDataResult<List<ProductDetailsDto>>(_productDal.GetProductDetails(), Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailsDto>>(_productDal.GetProductDetails(),Messages.ProductsListed);
        }
    }
}
