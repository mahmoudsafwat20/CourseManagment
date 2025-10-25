using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class EmployeeBadge
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int BadgeId { get; set; }
        public DateTime AwardedAt { get; set; } = DateTime.UtcNow;

       
    }
}
