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
    public class DisplayModel : PageModel
    {
        private readonly _03_CRUD_and_StateManagement.DataContext _context;

        public DisplayModel(_03_CRUD_and_StateManagement.DataContext context)
        {
            _context = context;
        }

        public IList<User> user { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.user != null)
            {
                user = await _context.user.ToListAsync();
            }
        }
    }
}
