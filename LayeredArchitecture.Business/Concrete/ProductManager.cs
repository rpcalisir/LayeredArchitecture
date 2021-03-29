﻿using LayeredArchitecture.Business.Abstract;
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

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public List<Product> GetAll() //?
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public List<Product> GetAllByUnitPrice(int min, int max)
        {
            return _productDal.GetAll(p => p.UnitPrice>=min&&p.UnitPrice<=max);
        }

        public List<ProductDetailsDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
