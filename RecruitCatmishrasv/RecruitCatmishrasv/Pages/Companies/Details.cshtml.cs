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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatmishrasv.Data.RecruitCatmishrasvContext _context;

        public DetailsModel(RecruitCatmishrasv.Data.RecruitCatmishrasvContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company
                
                .Include(x => x.Candidates)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
