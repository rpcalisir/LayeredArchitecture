﻿using LayeredArchitecture.Core.DataAccess.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Abstract
{
    public interface IOrderDal : IEntityDal<Order>
    {
    }
}
