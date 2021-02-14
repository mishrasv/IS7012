using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmishrasv.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("Position Name")]
        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        [Range(0,100000)]
        public decimal MinimumSalary { get; set; }

        [System.ComponentModel.DisplayName("Maximum Salary")]
        [Range(0,100000)]
        public decimal MaximumSalary { get; set; }

        [System.ComponentModel.DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [StringLength(200)]
        public string Location { get; set; }
        public bool MNC { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

    }
}
