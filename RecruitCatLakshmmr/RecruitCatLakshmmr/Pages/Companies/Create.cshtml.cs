using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatLakshmmr.Data;
using RecruitCatSrinivvv.Models;

namespace RecruitCatLakshmmr.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext _context;

        public CreateModel(RecruitCatLakshmmr.Data.RecruitCatLakshmmrContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CompanyIndustryId"] = new SelectList(_context.Industry, "IndustryId", "IndustryName");
            ViewData["JobPositionTitleId"] = new SelectList(_context.JobTitle, "JobTitleId", "Title");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
