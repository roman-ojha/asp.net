using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using libraryManagementSystem;
using libraryManagementSystem.Models;

namespace libraryManagementSystem.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly libraryManagementSystem.DataContext _context;

        public DeleteModel(libraryManagementSystem.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }

            var book = await _context.book.FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.book == null)
            {
                return NotFound();
            }
            var book = await _context.book.FindAsync(id);

            if (book != null)
            {
                Book = book;
                _context.book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
