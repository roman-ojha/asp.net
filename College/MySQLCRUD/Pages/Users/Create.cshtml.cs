using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MySQLCRUD.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly DataContext _dataContext;
        public CreateModel(DataContext context)
        {
            _dataContext = context;
        }
        [BindProperty]
        public User UserInfo { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            // Creating new user and saving it into database
            _dataContext.user.Add(UserInfo);
            _dataContext.SaveChanges();
        }
    }
}