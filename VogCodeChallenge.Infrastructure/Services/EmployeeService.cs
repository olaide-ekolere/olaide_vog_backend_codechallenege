using System;
using System.Collections.Generic;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Application.Interfaces;
using VogCodeChallenge.Application.Interfaces.Repositories;
using VogCodeChallenge.Application.Interfaces.Services;
namespace VogCodeChallenge.Infrastructure.Services
{
    public class EmployeeService
    {
        private IValidationDictionary _validationDictionary;
        private IEmployeeRepository _employeeRepository;
        public EmployeeService(IValidationDictionary validationDictionary,
            IEmployeeRepository employeeRepository)
        {
            _validationDictionary = validationDictionary;
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<Employee> GetAll() => _employeeRepository.GetAll();
        public IList<Employee> ListAll() => _employeeRepository.ListAll();
        public IEnumerable<Employee> GetAllByDepartment(int departmentId) => _employeeRepository.GetAllByDepartment(departmentId);
        public IList<Employee> ListAllByDepartment(int departmentId) => _employeeRepository.ListAllByDepartment(departmentId);

    }
}
