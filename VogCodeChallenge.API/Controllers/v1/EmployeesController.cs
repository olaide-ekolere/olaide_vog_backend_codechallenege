using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Application.Interfaces.Repositories;
using VogCodeChallenge.API.Application.Interfaces.Services;
using VogCodeChallenge.API.Infrastructure.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        IEmployeeService employeeService;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            employeeService = new EmployeeService(employeeRepository);
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employeeService.ListAll());
        }

        // GET api/values/5
        [HttpGet("department/{departmentId}")]
        public IActionResult GetByDepartment(int departmentId)
        {
            if (departmentId > 0)
            {
                return Ok(employeeService.ListAllByDepartment(departmentId));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
