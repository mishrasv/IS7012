using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatmishrasv.Models;

namespace RecruitCatmishrasv.Data
{
    public class RecruitCatmishrasvContext : DbContext
    {
        public RecruitCatmishrasvContext (DbContextOptions<RecruitCatmishrasvContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatmishrasv.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatmishrasv.Models.Company> Company { get; set; }

        public DbSet<RecruitCatmishrasv.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatmishrasv.Models.JobTitle> JobTitle { get; set; }
    }
}
