using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required] public string Name { get; set; } = null!;
        [Required] public string Email { get; set; } = null!;
        public int? SubscriptionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Subscription? Subscription { get; set; }
       
    }
}
