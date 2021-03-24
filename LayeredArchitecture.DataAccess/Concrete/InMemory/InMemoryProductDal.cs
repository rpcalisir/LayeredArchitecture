using LayeredArchitecture.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Concrete.InMemory
{
    //public class InMemoryProductDal<T> : IEntityDal<T>
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>();
        }
        public void Add(Product entity)
        {
            _products.Add(entity);
            Console.WriteLine(entity.ProductName + " is added");
        }

        public void Delete(Product entity)
        {
            _products.Remove(entity);
            Console.WriteLine(entity.ProductName + " is deleted");
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product,bool>> filter)
        {
            return _products;
        }

        public void Update(Product entity)
        {
            var item = _products.FirstOrDefault(x => x.ProductId == entity.ProductId);
            Console.WriteLine(entity.ProductName + " is being updated");

            if (item!= null)
            {
                item.ProductName = entity.ProductName;
                item.UnitPrice = entity.UnitPrice;
                item.UnitStock = entity.UnitStock;
                Console.WriteLine(entity.ProductName + " is updated value.");
            }
            else
            {
                Console.WriteLine("No such product");
            }
        }
    }
}
