using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages
{
    public class SessionWriteModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("Username", "hcoe");
            HttpContext.Session.SetString("Password", "csit");
            Console.WriteLine("Session Write");
        }
    }
}
