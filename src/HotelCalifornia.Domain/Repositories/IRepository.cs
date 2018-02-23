using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace HotelCalifornia.Domain.Repositories
{
    public interface IRepository<T> where T: class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Update(T entity);
    }
}