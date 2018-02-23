using System;
using System.Collections.Generic;

namespace HotelCalifornia.Domain.Repositories
{
    public interface IRepository<T> where T: class
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllWhere(Func<T> where);
        void Update();
    }
}