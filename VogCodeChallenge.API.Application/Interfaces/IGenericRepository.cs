using System;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        IList<T> ListAll();
    }
}
