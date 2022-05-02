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
        public void CreateEmployee(EmployeeDto employee)
        {
            try
            {
                _repository.CreateEmployee(employee);
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
                _repository.DeleteEmployee(employeeId);
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

        public void UpdateEmployee(EmployeeDto employee)
        {
            try
            {
                _repository.UpdateEmployee(employee);
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
