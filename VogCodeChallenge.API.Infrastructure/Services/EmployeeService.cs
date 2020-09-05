using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Domain.Entities;
using VogCodeChallenge.API.Application.Interfaces;
using VogCodeChallenge.API.Application.Interfaces.Repositories;
using VogCodeChallenge.API.Application.Interfaces.Services;
namespace VogCodeChallenge.API.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        //private IValidationDictionary _validationDictionary;
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            //_validationDictionary = validationDictionary;
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAll() => _employeeRepository.GetAll();
        public IList<Employee> ListAll() => _employeeRepository.ListAll();
        public IEnumerable<Employee> GetAllByDepartment(int departmentId) => _employeeRepository.GetAllByDepartment(departmentId);
        public IList<Employee> ListAllByDepartment(int departmentId) => _employeeRepository.ListAllByDepartment(departmentId);

    }
}
