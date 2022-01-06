using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInteratctions.Models.CohortModels
{
    public class CohortCreate
    {
        [Required]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [Display(Name = "Full Time")]
        public bool FullTime { get; set; }
    }
}
