using System;
using System.Collections.Generic;
using VogCodeChallenge.Domain.Entities;
namespace VogCodeChallenge.Application.Interfaces.Services
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        IEnumerable<Employee> GetAllByDepartment(int departmentId);
        IList<Employee> ListAllByDepartment(int departmentId);
    }
}
