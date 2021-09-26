using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSrinivvv.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        [DisplayName("Industry Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string IndustryName { get; set; }
        [DisplayName("Industry Sector")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string IndustrySector { get; set; }
        [DisplayName("Average Salary")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal? AverageSalary { get; set; }
        public List<Company> Companies { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
