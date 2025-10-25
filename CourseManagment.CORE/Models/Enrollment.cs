using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        [Required] public int EmployeeId { get; set; }
        [Required] public int CourseId { get; set; }
        public decimal Progress { get; set; } = 0;
        public string Status { get; set; } = "Active";
        public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;

        
    }
}
