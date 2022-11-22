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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager = null;
        private readonly IDepartmentManager _departmentManager = null;

        public EmployeeController(IEmployeeManager employeeManager, IDepartmentManager departmentManager)
        {
            _employeeManager = employeeManager;
            _departmentManager = departmentManager;
        }

        
        [HttpGet]
        //[Route("api/Employees")]
        public IActionResult GetEmployees()
        {
            var response = _employeeManager.GetEmployees();
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
        //[Route("api/Employees/{Id}")]
        public IActionResult GetEmployee(int id)
        {
            var response = _employeeManager.GetEmployee(id);
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
        //[Route("api/Employees/{Id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var response = _employeeManager.DeleteEmployee(id);
            if (response > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        //[Route("api/Employees")]
        public IActionResult CreateEmployee([FromBody] EmployeeDto employee)
        {
            var response = _employeeManager.CreateEmployee(employee);
            if (response != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        //[Route("api/Employees/{Id}")]
        public IActionResult Updatemployee([FromBody] EmployeeDto employee)
        {
            var response = _employeeManager.UpdateEmployee(employee);
            if (response > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}/departments")]
        //[Route("api/Employees/{Id}/Department")]
        public IActionResult GetDepartmentByEmployeeId(int id)
        {
            var response = _departmentManager.GetDepartmentByEmployeeId(id);
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
