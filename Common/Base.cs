﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Base
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}
