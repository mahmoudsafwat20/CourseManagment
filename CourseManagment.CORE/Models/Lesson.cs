using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.CORE.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        [Required] public int CourseId { get; set; }
        [Required] public string Title { get; set; } = null!;
        public string? ContentUrl { get; set; }
        public int? OrderIndex { get; set; }
        public int? Duration { get; set; }

    }
}
