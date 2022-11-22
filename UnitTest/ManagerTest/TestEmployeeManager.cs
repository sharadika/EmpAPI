using Business.Manager;
using Common.Dto;
using Data.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTest.ManagerTest
{
    public  class TestEmployeeManager
    {
        private readonly Mock<IRepository> _empMockRepo;
        private EmployeeManager _employeeManager;
        private readonly TestData _testData = new TestData();
        List<EmployeeDto> _employeeSampleList;
        public TestEmployeeManager()
        {
            _empMockRepo = new Mock<IRepository>();
            _employeeManager = new EmployeeManager(_empMockRepo.Object);
            _employeeSampleList = _testData.GetSampleEmployee();
        }

        [Fact()]
        public void Return_Employee_List()
        {
            //arrange
            _empMockRepo.Setup(x => x.GetEmployees())
                .Returns(_employeeSampleList);

            //act
            var result = _employeeManager.GetEmployees();

            //assert
            Assert.NotNull(result);
            Assert.Equal(_testData.GetSampleEmployee().Count(), result.Count());
        }

        [Fact]
        public void Return_Employee_List_When_Id_Exists()
        {
            //arrange
            var firstEmployee = _employeeSampleList.FirstOrDefault();
            _empMockRepo.Setup(x => x.GetEmployee((int)1))
                .Returns(firstEmployee);

            //act
            var result = _employeeManager.GetEmployee((int)1);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result, firstEmployee);
        }

        [Fact]
        public void Create_Employee()
        {
            //arrange
            var firstEmployee = _employeeSampleList.FirstOrDefault();
            _empMockRepo.Setup(x => x.CreateEmployee(firstEmployee))
                .Returns(firstEmployee);

            //act
            var actionResult = _employeeManager.CreateEmployee(firstEmployee);
            var result = actionResult.FirstName;

            //Assert
            Assert.NotNull(result);
            Assert.Equal("Jhon", result);
        }

        [Fact]
        public void Delete_EmployeeTest_When_Id_Exixts()
        {
            //arrange
            var firstEmployee = _employeeSampleList.FirstOrDefault();
            _empMockRepo.Setup(x => x.DeleteEmployee(firstEmployee.Id))
                .Returns(1);

            //act
            var result = _employeeManager.DeleteEmployee(firstEmployee.Id);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Update_Employee_When_Id_Exixts()
        {
            //arrange
            var firstEmployee = _employeeSampleList.FirstOrDefault();
            _empMockRepo.Setup(x => x.UpdateEmployee(firstEmployee))
                .Returns(1);

            //act
            var result = _employeeManager.UpdateEmployee(firstEmployee);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void GetDepartmentByEmployeeId__When_EmpId_Exixts()
        {
            var departments = _testData.GetSampleDepartment();
            _empMockRepo.Setup(x => x.GetEmployeesListByDepartmentId(1))
                .Returns(_employeeSampleList.Where(x => x.DepartmentId == 1).ToList());

            var result = _employeeManager.GetEmployeesListByDepartmentId(1);

            Assert.NotNull(result);
            Assert.Equal(result, _employeeSampleList.Where(x => x.DepartmentId == 1).ToList());
        }

    }
}
