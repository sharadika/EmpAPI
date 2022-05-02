using Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
    public interface IEmployeeManager
    {
        /// <summary>
        /// Get Employee List
        /// </summary>
        /// <returns>Employee List</returns>
        List<EmployeeDto> GetEmployees();

        /// <summary>
        /// Get specific Employee
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>Employee</returns>
        EmployeeDto GetEmployee(int employeeId);

        /// <summary>
        /// Create new Employee
        /// </summary>
        /// <param name="employee"></param>
        void CreateEmployee(EmployeeDto employee);

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="employee"></param>
        void UpdateEmployee(EmployeeDto employee);

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="employeeId"></param>
        void DeleteEmployee(int employeeId);

        /// <summary>
        /// Get EmployeeList By DepartmentId
        /// </summary>
        /// <returns>EmployeeList</returns>
        List<EmployeeDto> GetEmployeesListByDepartmentId(int departmentId);

    }
}
