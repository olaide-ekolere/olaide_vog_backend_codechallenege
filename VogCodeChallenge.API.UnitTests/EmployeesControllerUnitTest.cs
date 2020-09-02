using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using VogCodeChallenge.API.Controllers.v1;
using VogCodeChallenge.API.Domain.Entities;
using VogCodeChallenge.API.Infrastructure.Repositories;

namespace VogCodeChallenge.API.UnitTests
{
    public class EmployeesControllerUnitTest
    {
        [Fact]
        public void TestGetAllIsEmpty()
        {
            //Arrange
            var dbContext = DbContextMocker.GetApplicationDbContext(nameof(TestGetAllIsEmpty), false);
            var controller = new EmployeesController(new EmployeeRepository(dbContext));

            //Act
            var response = controller.Get() as ObjectResult;

            dbContext.Dispose();

            //Assert
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
            var employees = response.Value as IList<Employee>;
            Assert.Equal(0, employees.Count);
        }


        [Fact]
        public void TestGetAllAvailable()
        {
            //Arrange
            var dbContext = DbContextMocker.GetApplicationDbContext(nameof(TestGetAllAvailable), true);
            var controller = new EmployeesController(new EmployeeRepository(dbContext));

            //Act
            var response = controller.Get() as ObjectResult;

            dbContext.Dispose();

            //Assert
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
            var employees = response.Value as IList<Employee>;
            Assert.Equal(4, employees.Count);
        }


        [Fact]
        public void TestGetByDepartmentEmpty()
        {
            //Arrange
            var dbContext = DbContextMocker.GetApplicationDbContext(nameof(TestGetAllAvailable), true);
            var controller = new EmployeesController(new EmployeeRepository(dbContext));

            //Act
            var response = controller.GetByDepartment(89) as ObjectResult;

            dbContext.Dispose();

            //Assert
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
            var employees = response.Value as IList<Employee>;
            Assert.Equal(0, employees.Count);
        }


        [Fact]
        public void TestGetByDepartment()
        {
            //Arrange
            var dbContext = DbContextMocker.GetApplicationDbContext(nameof(TestGetAllAvailable), true);
            var controller = new EmployeesController(new EmployeeRepository(dbContext));

            //Act
            var response = controller.GetByDepartment(1) as ObjectResult;

            dbContext.Dispose();

            //Assert
            Assert.NotNull(response);
            Assert.IsType<OkObjectResult>(response);
            var employees = response.Value as IList<Employee>;
            Assert.Equal(2, employees.Count);
        }


        [Fact]
        public void TestGetByDepartmentInvalid()
        {
            //Arrange
            var dbContext = DbContextMocker.GetApplicationDbContext(nameof(TestGetAllAvailable), true);
            var controller = new EmployeesController(new EmployeeRepository(dbContext));

            //Act
            var response = controller.GetByDepartment(0);

            dbContext.Dispose();

            //Assert
            Assert.NotNull(response);
            Assert.IsType<BadRequestResult>(response);
        }
    }
}
