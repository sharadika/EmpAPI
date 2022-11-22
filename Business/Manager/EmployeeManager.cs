using Common.Dto;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        IRepository _repository = null;
        public EmployeeManager(IRepository repository)
        {
            _repository = repository;
        }
        public EmployeeDto CreateEmployee(EmployeeDto employee)
        {
            try
            {
                return _repository.CreateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteEmployee(int employeeId)
        {
            try
            {
                return _repository.DeleteEmployee(employeeId);
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
              return  _repository.GetEmployee(employeeId);
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
                return _repository.GetEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(EmployeeDto employee)
        {
            try
            {
                return _repository.UpdateEmployee(employee);
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
                return _repository.GetEmployeesListByDepartmentId(departmentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
