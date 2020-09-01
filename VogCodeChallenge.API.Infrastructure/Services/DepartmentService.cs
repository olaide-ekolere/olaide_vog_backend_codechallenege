using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Domain.Entities;
using VogCodeChallenge.API.Application.Interfaces;
using VogCodeChallenge.API.Application.Interfaces.Repositories;
using VogCodeChallenge.API.Application.Interfaces.Services;
namespace VogCodeChallenge.API.Infrastructure.Services
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
