using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Application.Interfaces.Repositories;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Infrastructure.Contexts;
namespace VogCodeChallenge.Infrastructure.Repositories
{
    public class EmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public bool Create(Employee employee)
        {
            try
            {
                _applicationDbContext.Employees.Add(employee);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                var employeeToUpdate = _applicationDbContext.Employees
                    .Where(c => c.Id == employee.Id)
                    .FirstOrDefault();
                if (employeeToUpdate == null) throw new Exception();
                employeeToUpdate.Address = employee.Address;
                employeeToUpdate.DepartmentId = employee.DepartmentId;
                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.JobTitle = employee.JobTitle;
                employeeToUpdate.LastName = employee.LastName;
                return _applicationDbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                var employeeToUpdate = _applicationDbContext.Employees
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
                if (employeeToUpdate == null) throw new Exception();
                _applicationDbContext.Entry(employeeToUpdate).State = EntityState.Deleted;
                return _applicationDbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _applicationDbContext.Employees.AsNoTracking().AsEnumerable();
        }

        public IList<Employee> ListAll()
        {
            return _applicationDbContext.Employees.AsNoTracking().ToList();
        }

        public IEnumerable<Employee> GetAllByDepartment(int departmentId)
        {
            return _applicationDbContext.Employees
                    .Where(c => c.DepartmentId == departmentId)
                    .AsNoTracking().AsEnumerable();
        }

        public IList<Employee> ListAllByDepartment(int departmentId)
        {
            return _applicationDbContext.Employees
                  .Where(c => c.DepartmentId == departmentId)
                  .AsNoTracking().ToList();
        }
    }
}
