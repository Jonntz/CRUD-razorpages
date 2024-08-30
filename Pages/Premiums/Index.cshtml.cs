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
    public class IndexModel : PageModel
    {
        private readonly StudentsPremiumCRUD.Data.ApplicationDbContext _context;

        public IndexModel(StudentsPremiumCRUD.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiums.ToListAsync();
        }
    }
}
