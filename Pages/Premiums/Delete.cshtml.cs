using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsPremiumCRUD.Data;
using StudentsPremiumCRUD.Models;

namespace StudentsPremiumCRUD.Pages.Premiums
{
    public class DeleteModel : PageModel
    {
        private readonly StudentsPremiumCRUD.Data.ApplicationDbContext _context;

        public DeleteModel(StudentsPremiumCRUD.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Premium Premium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiums.FirstOrDefaultAsync(m => m.Id == id);

            if (premium == null)
            {
                return NotFound();
            }
            else
            {
                Premium = premium;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiums.FindAsync(id);
            if (premium != null)
            {
                Premium = premium;
                _context.Premiums.Remove(Premium);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
