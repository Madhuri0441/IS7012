using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatLakshmmr.Data;
using RecruitCatSrinivvv.Models;

namespace RecruitCatLakshmmr.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext _context;

        public IndexModel(RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get; set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.TargetCompany)
                .Include(c => c.TargetIndustry)
                .Include(c => c.TargetJobTitle).ToListAsync();
        }
    }
}

