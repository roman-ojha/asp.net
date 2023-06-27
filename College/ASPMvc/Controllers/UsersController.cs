using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ASPMvc.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string username = form["user"];
            string password = form["pass"];
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;
            if (username == "" || password == "")
            {
                return View("Index");
            }
            else if(username == "admin" && password == "admin")
            {
                identity = new ClaimsIdentity(new[]{
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "Admin"), },
                    CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticated = true;
                return View("Admin");
            }
            else if(username == "user" && password == "user")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "User"), },
                 CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticated = true;
                return View("Home");
            }
            return View();
        }

        public IActionResult Home()
        {
            // returning /Users/Home view
            return View();
        }

        public IActionResult Contact()
        {
            // returning /Users/Contact view
            return View();
        }

        public IActionResult Admin()
        {
            // returning /Users/Admin view
            return View();
        }
    }
}
