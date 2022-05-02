using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("created_by")]
        public int CreatedBy { get; set; }
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }
        [Column("updated_by")]
        public int UpdatedBy { get; set; }
        [Column("updated_on")]
        public DateTime UpdatedOn { get; set; }
        [Column("is_deleted")]
        public Boolean IsDeleted { get; set; }
    }
}
