using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Infrastructure.Contexts;
using VogCodeChallenge.API.Domain.Entities;
namespace VogCodeChallenge.API.Infrastructure.Seed
{
    public static class TestData
    {
        public static void AddTestData(ApplicationDbContext applicationDbContext)
        {
            if (applicationDbContext.Departments.Any())
            {
                return;
            }
            else
            {
                var departments = new List<Department>() {
                    new Department
                    {
                        Id = 1,
                        Name = "Technology",
                        Address = "No 20 Technology Avenue, Ikoyi, Lagos"
                    },
                    new Department
                    {
                        Id = 2,
                        Name = "Customer Care",
                        Address = "No 08 Customer Care Avenue, VI, Lagos"
                    },
                    new Department
                    {
                        Id = 3,
                        Name = "Finance",
                        Address = "No 12 Finance Avenue, Ikeja, Lagos"
                    }
                };

                foreach(Department department in departments)
                {
                    applicationDbContext.Departments.Add(department);
                }
                applicationDbContext.SaveChanges();


                var employees = new List<Employee>() {
                    new Employee
                    {
                        FirstName = "Mary",
                        LastName = "Jane",
                        DepartmentId = departments[0].Id,
                        JobTitle = "Senior Software Developer",
                        Address = "Classified"
                    },
                     new Employee
                    {
                        FirstName = "Peter",
                        LastName = "Parker",
                        DepartmentId = departments[0].Id,
                        JobTitle = "Junior Software Developer",
                        Address = "Flat 10, Spiderman Avenue, Ikate, Lagos"
                    },
                      new Employee
                    {
                        FirstName = "Bruce",
                        LastName = "Wayne",
                        DepartmentId = departments[1].Id,
                        JobTitle = "Head of Sales",
                        Address = "Plot 8, Batcave tunnel, Egbeda, Ogun"
                    },
                       new Employee
                    {
                        FirstName = "Tommy",
                        LastName = "Hilfiger",
                        DepartmentId = departments[2].Id,
                        JobTitle = "Accountant level 3",
                        Address = "Classified"
                    }
                };

                applicationDbContext.SaveChanges();
            }
        }
    }
}
