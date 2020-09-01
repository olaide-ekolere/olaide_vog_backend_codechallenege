using System;
using System.Collections.Generic;
namespace VogCodeChallenge.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        IList<T> ListAll();
    }
}
