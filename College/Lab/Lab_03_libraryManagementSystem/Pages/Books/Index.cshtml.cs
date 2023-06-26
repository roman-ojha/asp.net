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
    public class IndexModel : PageModel
    {
        private readonly libraryManagementSystem.DataContext _context;

        public IndexModel(libraryManagementSystem.DataContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.book != null)
            {
                Book = await _context.book.ToListAsync();
            }
        }
    }
}
