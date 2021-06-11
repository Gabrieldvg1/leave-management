using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class DetailsLeaveTypeVM
    {
        //We create a LeaveTypeVM similar to the LeaveType in the Data folder so we can have more control
        //over what we want to show about this entity. Sometimes there could be information in the database
        //that we don't want to include in our ViewModel

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
        
    }
}
