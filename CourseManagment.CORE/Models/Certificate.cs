using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        [Required] public int EmployeeId { get; set; }
        [Required] public int CourseId { get; set; }
        [Required] public string CertificateCode { get; set; } = null!;
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
        public string? DownloadUrl { get; set; }

        
    }
}
