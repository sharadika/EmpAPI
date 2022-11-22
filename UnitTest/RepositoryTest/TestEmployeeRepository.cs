using AutoMapper;
using Common.Dto;
using Data;
using Data.Models;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.RepositoryTest
{
    public class TestEmployeeRepository
    {
        public readonly DbContextOptions<EmployeeContext> _dbOptions;
        private readonly IMapper _mapper;
        private EmployeeContext _empContext;
        private Repository _repository;
        private TestData testData = new TestData();
        public TestEmployeeRepository()
        {
            _dbOptions = new DbContextOptionsBuilder<EmployeeContext>()
                            .UseInMemoryDatabase(databaseName: "EmployeeDb")
                            .Options;

            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });
            _mapper = mockMapper.CreateMapper();
        }

        public void AddDataToDBContext()
        {
            _empContext = new EmployeeContext(_dbOptions);
            _repository = new Repository(_empContext, _mapper);

            var empList = testData.GetSampleEmployee();
            var depList = testData.GetSampleDepartment();

            //Add Employee List
            for (int i = 0; i < empList.Count; i++)
            {
                var newEmp = _mapper.Map<Employee>(empList[i]);

                _empContext.Employees.Add(newEmp);
                _empContext.SaveChanges();
            }

            //Add Department List
            for (int i = 0; i < depList.Count; i++)
            {
                var newDep = _mapper.Map<Department>(depList[i]);
                _empContext.Departments.Add(newDep);
                _empContext.SaveChanges();
            }
        }

        [Fact()]
        public void Create_Employee()
        {
            // Arrange
            var EmpContext = new EmployeeContext(_dbOptions);

            Repository repository = new Repository(EmpContext, _mapper);
            var newEmp = new EmployeeDto()
            {
                Id = 50,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                FirstName = "Micheal",
                LastName = "Bruce",
                City = "Rome",
                ContactNo = "0716163291",
                IsDeleted = false,
                DepartmentId = 10
            };

            // Act
            var result = repository.CreateEmployee(newEmp);

            // Assert
            Assert.NotNull(result);
        }

        [Fact()]
        public void Return_Employee_List()
        {
            // Arrange
            AddDataToDBContext();

            // Act
            var result = _repository.GetEmployees();

            // Assert
            Assert.True(result.Count > 0);
        }

        [Fact()]
        public void Return_EmployeeTest_When_Id_Exixts()
        {
            // Arrange
            AddDataToDBContext();

            // Act
            var result = _repository.GetEmployee(1);

            // Assert
            Assert.NotNull(result);
        }

        [Fact()]
        public void Delete_EmployeeTest_When_Id_Exixts()
        {
            // Arrange
            AddDataToDBContext();

            // Act
            var result = _repository.DeleteEmployee(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact()]
        public void Update_Employee_When_Id_Exixts()
        {
            // Arrange
            AddDataToDBContext();

            var newEmp = new EmployeeDto()
            {
                Id = 1,
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                FirstName = "Micheal_New",
                LastName = "Bruce_New",
                City = "Rome_New",
                ContactNo = "0716163292",
                DepartmentId = 2
            };

            // Act
            var result = _repository.UpdateEmployee(newEmp);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetDepartmentByEmployeeId__When_EmpId_Exixts()
        {
            //Arrange
            AddDataToDBContext();

            // Act
            var result = _repository.GetDepartmentByEmployeeId(1);

            // Assert
            Assert.NotNull(result);
        }
    }
}
