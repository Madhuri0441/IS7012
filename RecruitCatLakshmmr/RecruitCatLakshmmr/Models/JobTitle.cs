using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSrinivvv.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        [DisplayName("Job Title")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal MaxSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
