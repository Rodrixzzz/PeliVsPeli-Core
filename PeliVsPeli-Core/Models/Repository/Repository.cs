using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PeliVsPeli_Core.Models.Interface;

namespace PeliVsPeli_Core.Models.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        readonly EFContex _EFContex;
        public Repository(EFContex Context)
        {
            _EFContex = Context;
        }
        public void Create(T entity)
        {
            this._EFContex.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this._EFContex.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return this._EFContex.Set<T>();
        }

        public T GetById(Expression<Func<T, bool>> expression)
        {
            return _EFContex.Set<T>().FirstOrDefault(expression);
        }

        public void Update(T entity)
        {
            this._EFContex.Set<T>().Update(entity);
        }
        public void Save()
        {
            this._EFContex.SaveChanges();
        }
    }
}
