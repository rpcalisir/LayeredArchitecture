using LayeredArchitecture.Core.DataAccess.Abstract;
using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityDalBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailsDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryID equals c.CategoryId
                             select new ProductDetailsDto
                             {
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 SupplierID = p.SupplierID,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
