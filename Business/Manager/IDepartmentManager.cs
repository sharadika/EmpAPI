using Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
   public interface IDepartmentManager
    {
        List<DepartmentDto> GetDepartments();
        DepartmentDto GetDepartment(int departmentId);
        DepartmentDto CreateDepartment(DepartmentDto department);
        DepartmentDto UpdateDepartment(DepartmentDto department);
        void DeleteDepartment(int departmentId);
        DepartmentDto GetDepartmentByEmployeeId(int employeeId);
    }
}
