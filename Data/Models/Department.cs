
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Department")]
    public class Department : BaseEntity
    {
        [Required(ErrorMessage = "Department Name is required")]
        [Column("department_name")]
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        
    }
}
