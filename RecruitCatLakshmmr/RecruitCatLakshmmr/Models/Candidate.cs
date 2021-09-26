using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSrinivvv.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        [DisplayName("First Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal TargetSalary { get; set; }
        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DisplayName("Years of Experience")]
        [Range(0, 51)]
        public int? YearsOfExperience { get; set; }
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email Id")]
        [EmailAddress]
        public string EmailId { get; set; }
        [DisplayName("Phone Number")]
        [Phone]
        public string Phone { get; set; }
        [DisplayName("Target Company")]
        public Company TargetCompany { get; set; }
        [DisplayName("Target Company")]
        public int? TargetCompanyId { get; set; }
        [DisplayName("Target Job Title")]
        public JobTitle TargetJobTitle { get; set; }
        [DisplayName("Target Job Title")]
        public int TargetJobTitleId { get; set; }
        [DisplayName("Target Industry")]
        public Industry TargetIndustry { get; set; }
        [DisplayName("Target Industry")]
        public int TargetIndustryId { get; set; }
        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
