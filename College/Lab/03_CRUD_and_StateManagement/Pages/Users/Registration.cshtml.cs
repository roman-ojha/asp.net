using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _03_CRUD_and_StateManagement;
using _03_CRUD_and_StateManagement.Models;

namespace _03_CRUD_and_StateManagement.Pages.Users
{
    public class RegistrationModel : PageModel
    {
        private readonly _03_CRUD_and_StateManagement.DataContext _context;

        public RegistrationModel(_03_CRUD_and_StateManagement.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User user { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.user == null || user == null)
            {
                return Page();
            }

            _context.user.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
