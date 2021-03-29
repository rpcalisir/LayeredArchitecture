using LayeredArchitecture.Business.Concrete;
using LayeredArchitecture.DataAccess.Concrete.EntityFramework;
using LayeredArchitecture.DataAccess.Concrete.InMemory;
using LayeredArchitecture.Entities.Concrete;
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

            //var products = productManager.GetAll();
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //OrderManager orderManager = new OrderManager(new EfOrderDal());
            //var orders = orderManager.GetAll();
            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order.OrderID);
            //}

            //var productDetails = productManager.GetProductDetails();
            //foreach (var detail in productDetails)
            //{
            //    Console.WriteLine(detail.ProductName);
            //}

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.ProductId);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //var pro = productManager.Add(new Product 
            //{ 
            //    CategoryID = 1,
            //    ProductName = "Orange Juice",
            //    SupplierID = 1,
            //    QuantityPerUnit = "5",
            //    UnitPrice = 10
            //});
            //Console.WriteLine(pro.Success);


            Console.ReadLine();
        }
    }
}
