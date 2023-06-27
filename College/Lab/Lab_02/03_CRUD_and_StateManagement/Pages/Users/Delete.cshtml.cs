using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _03_CRUD_and_StateManagement;
using _03_CRUD_and_StateManagement.Models;

namespace _03_CRUD_and_StateManagement.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly _03_CRUD_and_StateManagement.DataContext _context;

        public DeleteModel(_03_CRUD_and_StateManagement.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.user == null)
            {
                return NotFound();
            }

            var user = await _context.user.FirstOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.user == null)
            {
                return NotFound();
            }
            var user = await _context.user.FindAsync(id);

            if (user != null)
            {
                User = user;
                _context.user.Remove(User);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
