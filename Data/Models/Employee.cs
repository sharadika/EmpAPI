using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Employee : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("department_id")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
