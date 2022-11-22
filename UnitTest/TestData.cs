using Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class TestData
    {
        public List<EmployeeDto> GetSampleEmployee()
        {
            List<EmployeeDto> output = new List<EmployeeDto>
        {
            new EmployeeDto
            {
                Id = 1,
                FirstName = "Jhon",
                LastName = "Doe",
                ContactNo = "0716163291",
                City ="Washington",
                DepartmentId = 1,
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            },
            new EmployeeDto
            {
                Id = 2,
                FirstName = "Helan",
                LastName = "Smith",
                ContactNo = "0716163292",
                City ="New York",
                DepartmentId = 2,
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            },
            new EmployeeDto
            {
                Id = 3,
                FirstName = "Keran",
                LastName = "Moulder",
                ContactNo = "0716163293",
                City ="LA",
                DepartmentId = 3,
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            }
        };
            return output;
        }

        public List<DepartmentDto> GetSampleDepartment()
        {
            List<DepartmentDto> output = new List<DepartmentDto>
        {
            new DepartmentDto
            {
                Id = 1,
                DepartmentName = "IT",
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            },
            new DepartmentDto
            {
                Id = 2,
                DepartmentName = "HR",
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            },
            new DepartmentDto
            {
                Id = 3,
                DepartmentName = "Finance",
                IsDeleted = false,
                CreatedBy = 1001,
                CreatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000"),
                UpdatedBy = 1002,
                UpdatedOn = DateTime.Parse("2022-04-05 00:00:00.0000000")
            }
        };
            return output;
        }
    }
}
