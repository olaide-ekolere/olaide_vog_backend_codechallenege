using System;
using System.Collections.Generic;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Application.Interfaces;
using VogCodeChallenge.Application.Interfaces.Repositories;
using VogCodeChallenge.Application.Interfaces.Services;
namespace VogCodeChallenge.Infrastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        private IValidationDictionary _validationDictionary;
        private IDepartmentRepository _departmentRepository;
        public DepartmentService(IValidationDictionary validationDictionary,
            IDepartmentRepository departmentRepository)
        {
            _validationDictionary = validationDictionary;
            _departmentRepository = departmentRepository;
        }
        public IEnumerable<Department> GetAll() => _departmentRepository.GetAll();
        public IList<Department> ListAll() => _departmentRepository.ListAll();
    }
}
