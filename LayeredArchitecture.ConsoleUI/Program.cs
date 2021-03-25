using LayeredArchitecture.Business.Concrete;
using LayeredArchitecture.DataAccess.Concrete.EntityFramework;
using LayeredArchitecture.DataAccess.Concrete.InMemory;
using System;

namespace LayeredArchitecture.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //productManager.Add(new Entities.Concrete.Product {
            //    ProductId =1,
            //    CategoryId = 1,
            //    ProductName = "Basket",
            //    UnitPrice = 200,
            //    UnitStock = 50
            //});

            var products = productManager.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            OrderManager orderManager = new OrderManager(new EfOrderDal());
            var orders = orderManager.GetAll();
            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderID);
            }

            Console.ReadLine();
        }
    }
}
