using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        [Required] //This mean that Name won't allow Null values
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
