using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Domain.Entities;

namespace VogCodeChallenge.API.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetAllByDepartment(int departmentId);
        IList<Employee> ListAllByDepartment(int departmentId);
    }
}
