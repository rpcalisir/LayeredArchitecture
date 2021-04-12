﻿ using LayeredArchitecture.Core.Entities.Abstract;
using LayeredArchitecture.Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.Core.DataAccess.Abstract
{
    public interface IEntityDal<T> where T: class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
    }
}
