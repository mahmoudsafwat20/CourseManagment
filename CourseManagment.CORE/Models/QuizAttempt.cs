using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class QuizAttempt
    {
        public int QuizAttemptId { get; set; }
        [Required] public int EmployeeId { get; set; }
        [Required] public int QuizId { get; set; }
        public int? Score { get; set; }
        public DateTime AttemptDate { get; set; } = DateTime.UtcNow;
        public bool Passed { get; set; }

        
    }
}
