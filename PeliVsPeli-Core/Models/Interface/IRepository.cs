using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PeliVsPeli_Core.Models.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
