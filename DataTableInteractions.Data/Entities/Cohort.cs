using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInteractions.Data.Entities
{
    public class Cohort
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public bool FullTime { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public virtual ICollection<InstructorAssignment> InstructorAssignments { get; set; } = new List<InstructorAssignment>();

    }
}
