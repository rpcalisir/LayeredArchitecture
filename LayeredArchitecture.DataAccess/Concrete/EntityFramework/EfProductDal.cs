﻿using LayeredArchitecture.Core.DataAccess.Abstract;
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
        
    }
}
