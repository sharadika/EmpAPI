using Business.Manager;
using Common.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager = null;
        private readonly IEmployeeManager _employeeManager = null;


        public DepartmentController(IDepartmentManager departmentManager, IEmployeeManager employeeManager)
        {
            _departmentManager = departmentManager;
            _employeeManager = employeeManager;
        }
        
        [HttpGet]
        //[Route("api/Departments")]
        public IActionResult GetDepartments()
        {
            var response = _departmentManager.GetDepartments();
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        //[Route("/{Id}")]
        public IActionResult GetDepartment(int id)
        {
            var response = _departmentManager.GetDepartment(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        //[Route("api/Departments/{Id}")]
        public IActionResult DeleteDepartment(int id)
        {
            _departmentManager.DeleteDepartment(id);
            return Ok();
        }

        [HttpPost]
        //[Route("api/Departments")]
        public IActionResult CreateDepartment([FromBody] DepartmentDto department)
        {
            _departmentManager.CreateDepartment(department);
            return Ok();
        }

        [HttpPut("{id}")]
        //[Route("api/Departments/{Id}")]
        public IActionResult UpdateDepartment([FromBody] DepartmentDto department)
        {
            _departmentManager.UpdateDepartment(department);
            return Ok();
        }

        [HttpGet("{id}/employees")]
        //[Route("api/Departments/{Id}/Employees")]
        public IActionResult GetEmployeeListByDepartmentId(int id)
        {
            var response = _employeeManager.GetEmployeesListByDepartmentId(id);
            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
