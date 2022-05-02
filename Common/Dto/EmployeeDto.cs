using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EmployeeDto : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }

    }
}
