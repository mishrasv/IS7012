using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatmishrasv.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [System.ComponentModel.DisplayName("Minimum Salary")]
        [Range(0,100000)]
        public decimal MinimumSalary { get; set; }

        [System.ComponentModel.DisplayName("Maximum Salary")]
        [Range(0,100000)]
        public decimal MaximumSalary { get; set; }
        public decimal Bonus { get; set; }
        [Range(0,10000)]

        [System.ComponentModel.DisplayName("Contract Year")]
        public int ContractYear { get; set; }
        [Range(0,10)]
        public List<Candidate> Candidates { get; set; }


    }
}
