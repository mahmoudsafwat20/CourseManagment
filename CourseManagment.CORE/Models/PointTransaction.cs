using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class PointTransaction
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        [Required] public int EmployeeId { get; set; }
        [Required] public int Points { get; set; }
        public string? Reason { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

    }
}
