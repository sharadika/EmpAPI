using Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IRepository
    {
        #region Employee
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
        /// <param name="id"></param>
        /// <returns>Employee List</returns>
        List<EmployeeDto> GetEmployeesListByDepartmentId(int departmentId);
        #endregion

        #region Department
        List<DepartmentDto> GetDepartments();
        DepartmentDto GetDepartment(int departmentId);
        DepartmentDto CreateDepartment(DepartmentDto department);
        DepartmentDto UpdateDepartment(DepartmentDto department);
        void DeleteDepartment(int departmentId);
        DepartmentDto GetDepartmentByEmployeeId(int employeeId);
        #endregion
    }
}
