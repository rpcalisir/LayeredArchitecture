 using LayeredArchitecture.Entities.Abstract;
using LayeredArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.DataAccess.Abstract
{
    public interface IEntityDal<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity );
    }
}
