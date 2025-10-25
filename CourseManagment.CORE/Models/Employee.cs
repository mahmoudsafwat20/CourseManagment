using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required] public int CompanyId { get; set; }
        [Required] public string FullName { get; set; } = null!;
        [Required] public string Email { get; set; } = null!;
        public string? JobTitle { get; set; }
        [Required] public string PasswordHash { get; set; } = null!;
        public int Points { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Company Company { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();
        public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<EmployeeBadge> EmployeeBadges { get; set; } = new List<EmployeeBadge>();
        public ICollection<PointTransaction> PointTransactions { get; set; } = new List<PointTransaction>();
    }
}
