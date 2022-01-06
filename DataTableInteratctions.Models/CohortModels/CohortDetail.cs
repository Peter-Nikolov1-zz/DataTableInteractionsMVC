using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInteratctions.Models.CohortModels
{
    public class CohortDetail
    {
        public int Id { get; set; }

        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public string Language { get; set; }

        [Display(Name = "Full Time")]
        public bool FullTime { get; set; }
    }
}
