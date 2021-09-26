using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSrinivvv.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [DisplayName("Company Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string CompanyName { get; set; }
        [DisplayName("Location")]
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string CompanyLocaton { get; set; }
        [DisplayName("Company Email Id")]
        [EmailAddress]
        public string CompanyEmailId { get; set; }
        [DisplayName("Company Website")]
        [Url]
        public string CompanyUrl { get; set; }
        [DisplayName("Position")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string PositionName { get; set; }
        [DisplayName("Minimum Salary")]
        [Range(0,(double)decimal.MaxValue)]
        public decimal? MinSalary { get; set; }
        [DisplayName("Maximum Salary")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal? MaxSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Availibility")]
        public bool IsPositionAvailable { get; set; }
        [DisplayName("Company Start Date")]
        [DataType(DataType.Date)]
        public DateTime CompanyStartDate { get; set; }
        [DisplayName("Candidates")]
        public List<Candidate> Candidates { get; set; }
        [DisplayName("Industry")]
        public Industry CompanyIndustry { get; set; }
        [DisplayName("Industry")]
        public int CompanyIndustryId { get; set; }
        [DisplayName("Job Title")]
        public JobTitle JobPositionTitle { get; set; }
        [DisplayName("Job Title")]
        public int? JobPositionTitleId { get; set; }
    }
}
