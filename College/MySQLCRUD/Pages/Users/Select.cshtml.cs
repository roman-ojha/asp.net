using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySQLCRUD.Pages.Users
{
    public class SelectModel : PageModel
    {
        private readonly DataContext _dataContext;
        public SelectModel(DataContext context)
        {
            _dataContext = context;
        }
        public IList<User> listUsers { get; set; } = default!;
        public void OnGet()
        {
            if (_dataContext.user != null)
            {
                listUsers = _dataContext.user.ToList();
            }
        }
    }
}