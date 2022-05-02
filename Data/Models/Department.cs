
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Department : BaseEntity
    {
        [Column("department_name")]
        public string DepartmentName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        
    }
}
