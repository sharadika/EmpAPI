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
        public void CreateEmployee(EmployeeDto employee)
        {
            var addEmp = _mapper.Map<Employee>(employee);
            try
            {
                _Context.Employees.Add(addEmp);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            try
            {
                var employee = _Context.Employees.Where(x => x.Id == employeeId && x.IsDeleted != true).FirstOrDefault();

                if (employee == null)
                {
                    throw new Exception("Employee not found");
                }
                else
                {
                    employee.IsDeleted = true;
                    _Context.Employees.Update(employee);
                    _Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public EmployeeDto GetEmployee(int employeeId)
        {
            try
            {
                var query = _Context.Employees.Where(x => x.Id == employeeId && x.IsDeleted != true).FirstOrDefault();
                return _mapper.Map<EmployeeDto>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<EmployeeDto> GetEmployees()
        {
            try
            {
                var query = _Context.Employees.Where(x => x.IsDeleted != true);
                return _mapper.Map<IEnumerable<EmployeeDto>>(query).ToList();

                //return query.Select(p => _mapper.Map<EmployeeDto>(p)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateEmployee(EmployeeDto employee)
        {
            try
            {
                var existingEmployee = _Context.Employees.Where(x => x.Id == employee.Id && x.IsDeleted != true).FirstOrDefault();
                if (existingEmployee == null)
                {
                    throw new Exception("Employee not found");
                }
                else
                {
                    existingEmployee.FirstName = employee.FirstName;
                    existingEmployee.LastName = employee.LastName;
                    existingEmployee.City = employee.City;
                    existingEmployee.DepartmentId = employee.DepartmentId;
                    existingEmployee.UpdatedBy = employee.UpdatedBy;
                    existingEmployee.UpdatedOn = DateTime.UtcNow;

                    _Context.Employees.Update(existingEmployee);
                    _Context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EmployeeDto> GetEmployeesListByDepartmentId(int departmentId)
        {
            try
            {
                var department = _Context.Departments.Where(x => x.Id == departmentId && x.IsDeleted != true).FirstOrDefault();
                if (department != null)
                {
                    var query = _Context.Employees
                                 .Include(x => x.Department)
                                 .Where(x => x.DepartmentId == departmentId && x.IsDeleted != true);
                    return _mapper.Map<IEnumerable<EmployeeDto>>(query).ToList();
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
