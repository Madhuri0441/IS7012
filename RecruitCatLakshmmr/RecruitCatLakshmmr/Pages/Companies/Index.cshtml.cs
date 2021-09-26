using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatLakshmmr.Data;
using RecruitCatSrinivvv.Models;

namespace RecruitCatLakshmmr.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext _context;

        public IndexModel(RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company
                .Include(c => c.CompanyIndustry)
                .Include(c => c.JobPositionTitle).ToListAsync();
        }
    }
}
