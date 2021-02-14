using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmishrasv.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [System.ComponentModel.DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [System.ComponentModel.DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [System.ComponentModel.DisplayName("Phone Number")]
        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [System.ComponentModel.DisplayName("Target Salary")]
        [Range(0,100000)]
        public decimal TargetSalary { get; set; }

        [System.ComponentModel.DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }

        [System.ComponentModel.DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

    }
}
