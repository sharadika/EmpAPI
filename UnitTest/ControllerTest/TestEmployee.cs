using Autofac.Core;
using Business.Manager;
using Common.Dto;
using Data.Models;
using Data.Repository;
using EmployeeAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTest
{
    public class TestEmployee
    {
        private readonly Mock<IEmployeeManager> _empMock;
        private readonly Mock<IDepartmentManager> _depMock;
        private readonly TestData _testData = new TestData();
        private  EmployeeController _empController;
        public TestEmployee()
        {
            _empMock = new Mock<IEmployeeManager>();
            _depMock = new Mock<IDepartmentManager>();
            _empController = new EmployeeController(_empMock.Object, _depMock.Object);
        }

        [Fact]
        public void Return_Employee_List()
        {
            //arrange
            var employee = _testData.GetSampleEmployee();
            _empMock.Setup(x => x.GetEmployees())
                .Returns(employee);

            //act
            var actionResult = _empController.GetEmployees() as OkObjectResult;
            var result = actionResult.Value as List<EmployeeDto>;

            //assert
            Assert.NotNull(result);
            Assert.Equal(_testData.GetSampleEmployee().Count(), result.Count());

        }
        [Fact]
        public void Return_Employee_List_When_Id_Exists()
        {
            //arrange
            var employees = _testData.GetSampleEmployee();
            var firstEmployee = employees.FirstOrDefault();
            _empMock.Setup(x => x.GetEmployee((int)1))
                .Returns(firstEmployee);

            //act
            var actionResult = _empController.GetEmployee((int)1) as OkObjectResult; 
            var result = actionResult.Value;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result, firstEmployee);
        }

        [Fact]
        public void Create_Employee()
        {
            //arrange
            var employees = _testData.GetSampleEmployee();
            var firstEmployee = employees.FirstOrDefault();
            _empMock.Setup(x => x.CreateEmployee(firstEmployee))
                .Returns(firstEmployee);

            //act
            var actionResult = _empController.CreateEmployee(firstEmployee);
            var result = actionResult.GetType().Name;

            //Assert
            Assert.NotNull(result);
            Assert.Equal("OkResult", result);
        }

        [Fact]
        public void Delete_EmployeeTest_When_Id_Exixts()
        {
            //arrange
            var employees = _testData.GetSampleEmployee();
            var firstEmployee = employees.FirstOrDefault();
            _empMock.Setup(x => x.DeleteEmployee(firstEmployee.Id))
                .Returns(1);

            //act
            var actionResult = _empController.DeleteEmployee(firstEmployee.Id);
            var result = actionResult.GetType().Name;

            //Assert
            Assert.NotNull(result);
            Assert.Equal("OkResult", result);
        }

        [Fact]
        public void Update_Employee_When_Id_Exixts()
        {
            //arrange
            var employees = _testData.GetSampleEmployee();
            var firstEmployee = employees.FirstOrDefault();
            _empMock.Setup(x => x.UpdateEmployee(firstEmployee))
                .Returns(1);

            //act
            var actionResult = _empController.Updatemployee(firstEmployee);
            var result = actionResult.GetType().Name;

            //Assert
            Assert.NotNull(result);
            Assert.Equal("OkResult", result);
        }

        [Fact]
        public void GetDepartmentByEmployeeId__When_EmpId_Exixts()
        {
            var employees = _testData.GetSampleEmployee();
            var departments = _testData.GetSampleDepartment();
            _depMock.Setup(x => x.GetDepartmentByEmployeeId(employees.FirstOrDefault().Id))
                .Returns(departments.FirstOrDefault());

            var actionResult = _empController.GetDepartmentByEmployeeId(1) as OkObjectResult;
            var result = actionResult.Value;

            Assert.NotNull(result);
            Assert.Equal(result, departments.FirstOrDefault());
        }
    }
}
