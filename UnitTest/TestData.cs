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
                DepartmentId = 1
            },
            new EmployeeDto
            {
                Id = 2,
                FirstName = "Helan",
                LastName = "Smith",
                ContactNo = "0716163292",
                City ="New York",
                DepartmentId = 2
            },
            new EmployeeDto
            {
                Id = 3,
                FirstName = "Keran",
                LastName = "Moulder",
                ContactNo = "0716163293",
                City ="LA",
                DepartmentId = 3
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
                DepartmentName = "IT"
            },
            new DepartmentDto
            {
                Id = 2,
                DepartmentName = "HR"
            },
            new DepartmentDto
            {
                Id = 3,
                DepartmentName = "Finance"
            }
        };
            return output;
        }
    }
}
