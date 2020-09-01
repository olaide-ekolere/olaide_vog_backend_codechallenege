using System;
using System.Collections.Generic;
using VogCodeChallenge.Domain.Entities;

namespace VogCodeChallenge.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetAllByDepartment(int departmentId);
        IList<Employee> ListAllByDepartment(int departmentId);
    }
}
