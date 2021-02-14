using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatmishrasv.Data;
using RecruitCatmishrasv.Models;

namespace RecruitCatmishrasv.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatmishrasv.Data.RecruitCatmishrasvContext _context;

        public IndexModel(RecruitCatmishrasv.Data.RecruitCatmishrasvContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
