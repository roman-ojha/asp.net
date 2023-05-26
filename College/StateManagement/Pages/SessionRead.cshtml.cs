using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages
{
    public class SessionReadModel : PageModel
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public void OnGet()
        {
            // User = HttpContext.Session.GetString("Username");
            // Pass = HttpContext.Session.GetString("Password");
        }
    }
}
