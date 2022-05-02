using AutoMapper;
using Common.Dto;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public partial class Repository
    {
        public DepartmentDto CreateDepartment(DepartmentDto department)
        {
            try
            {
                var newDepartment = _mapper.Map<Department>(department);
                _Context.Departments.Add(newDepartment);
                _Context.SaveChanges();

                return department;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            try
            {
                var department = _Context.Departments.Where(x => x.Id == departmentId && x.IsDeleted != true).FirstOrDefault();
                if (department ==null)
                {
                    throw new Exception("Department not found");
                }
                else
                {
                    department.IsDeleted = true;
                    _Context.Departments.Update(department);
                    _Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DepartmentDto GetDepartment(int departmentId)
        {
            try
            {
                var query = _Context.Departments.Where(x => x.Id == departmentId && x.IsDeleted != true).FirstOrDefault();
                return _mapper.Map<DepartmentDto>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DepartmentDto> GetDepartments()
        {
            try
            {
                var query = _Context.Departments.Where(x => x.IsDeleted != true);
                return  _mapper.Map<IEnumerable<DepartmentDto>>(query).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DepartmentDto UpdateDepartment(DepartmentDto department)
        {
            try
            {
                var existingdepartment = _Context.Departments.Where(x => x.Id == department.Id && x.IsDeleted != true).FirstOrDefault();
                if (department == null)
                {
                    throw new Exception("Department not found");
                }
                else
                {
                    existingdepartment.DepartmentName = department.DepartmentName;
                    existingdepartment.UpdatedBy = department.UpdatedBy;
                    existingdepartment.UpdatedOn = DateTime.UtcNow;
                    _Context.Departments.Update(existingdepartment);
                    _Context.SaveChanges();

                    return department;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DepartmentDto GetDepartmentByEmployeeId(int employeeId)
        {
            try
            {
                var employee = _Context.Employees.Where(x => x.Id == employeeId && x.IsDeleted != true).FirstOrDefault();
                if (employee != null) {
                    var query = _Context.Employees
                                 .Include(x => x.Department)
                                 .Where(x => x.Id == employeeId && x.Department.IsDeleted != true)
                                 .Select(x => x.Department)
                                 .FirstOrDefault();
                    return _mapper.Map<DepartmentDto>(query);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
