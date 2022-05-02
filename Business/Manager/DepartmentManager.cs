using Common.Dto;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Manager
{
    public class DepartmentManager : IDepartmentManager
    {
        IRepository _repository = null;
        public DepartmentManager(IRepository repository)
        {
            _repository = repository;
        }
        public DepartmentDto CreateDepartment(DepartmentDto department)
        {
            try
            {
                return _repository.CreateDepartment(department);
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
                _repository.DeleteDepartment(departmentId);
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
                return _repository.GetDepartment(departmentId);
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
                return _repository.GetDepartments();
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
                return _repository.UpdateDepartment(department);
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
                return _repository.GetDepartmentByEmployeeId(employeeId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
