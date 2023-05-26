using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySQLCRUD.Pages.Users
{
    public class DeleteModel : PageModel
    {
        private readonly DataContext _dataContext;
        public DeleteModel(DataContext context)
        {
            _dataContext = context;
        }
        public IList<User> listUsers { get; set; } = default!;

        [BindProperty]
        public int id { get; set; }

        public void OnGet()
        {
            if (_dataContext.user != null)
            {
                listUsers = _dataContext.user.ToList();
            }
        }

        public void OnPost()
        {
            Console.WriteLine(this.id);
        }
    }
}