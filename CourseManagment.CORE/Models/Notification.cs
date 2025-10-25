using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Notification
    {
        public int NotificationId { get; set; }
        [Required] public int EmployeeId { get; set; }
        [Required] public string Message { get; set; } = null!;
        public string? Type { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
