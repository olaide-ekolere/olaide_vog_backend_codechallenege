using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Application.Interfaces.Repositories;
using VogCodeChallenge.API.Domain.Entities;
using VogCodeChallenge.API.Infrastructure.Contexts;
namespace VogCodeChallenge.API.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly ApplicationDbContext _applicationDbContext;
        public DepartmentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public bool Create(Department department)
        {
            try
            {
                _applicationDbContext.Departments.Add(department);
                _applicationDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Department department)
        {
            try
            {
                var departmentToUpdate = _applicationDbContext.Departments
                    .Where(c => c.Id == department.Id)
                    .FirstOrDefault();
                if (departmentToUpdate == null) throw new Exception();
                departmentToUpdate.Address = department.Address;
                departmentToUpdate.Name = department.Name;
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
                var departmentToUpdate = _applicationDbContext.Departments
                    .Where(c => c.Id == id)
                    .FirstOrDefault();
                if (departmentToUpdate == null) throw new Exception();
                _applicationDbContext.Entry(departmentToUpdate).State = EntityState.Deleted;
                return _applicationDbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Department> GetAll()
        {
            return _applicationDbContext.Departments.AsNoTracking().AsEnumerable();
        }

        public IList<Department> ListAll()
        {
            return _applicationDbContext.Departments.AsNoTracking().ToList();
        }
    }
}
