using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
    public class EmployeeDto : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string City { get; set; }
        public int DepartmentId { get; set; }

    }
}
