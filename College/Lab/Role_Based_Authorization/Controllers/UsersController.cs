using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Lab_06_Role_Based_Authentication.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult List()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var username = identity.FindFirst(ClaimTypes.Name)?.Value;
                var role = identity.FindFirst(ClaimTypes.Role)?.Value;
                if (username == "admin" && role == "admin")
                    return View();
                else if (username == "user" && role == "user")
                    return View();
                else
                    return View("_404");
                
            }
            return View("Login");
        }

        public IActionResult _404()
        {
            return View();
        }

        public IActionResult Delete()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var username = identity.FindFirst(ClaimTypes.Name)?.Value;
                var role = identity.FindFirst(ClaimTypes.Role)?.Value;
                if (username == "admin" && role == "admin")
                    return View();
                else
                    return View("_404");
                
            }
            return View("");
        }

        public IActionResult Create()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var username = identity.FindFirst(ClaimTypes.Name)?.Value;
                var role = identity.FindFirst(ClaimTypes.Role)?.Value;
                if (username == "admin" && role == "admin")
                    return View();
                else
                    return View("_404");
                
            }
            return View("Login");
        }

        public IActionResult LoginSubmit(string username, string password)
        {
            if (username == "" && password == "")
            {
                return RedirectToAction("Login");
            }
            else
            {
                //using System.Security.Claims
                ClaimsIdentity identity = null;
                bool isAuthenticated = false;
                if (username == "admin" && password == "admin")
                {
                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, username),
                         new Claim(ClaimTypes.Role,"admin"),
                    },
                    CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticated = true;
                }
                if (username == "user" && password == "user")
                {


                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, username),
                         new Claim(ClaimTypes.Role,"user"),
                    },
                    CookieAuthenticationDefaults.AuthenticationScheme);
                    //using Microsoft.AspNetCore.Authentication.Cookies;
                    isAuthenticated = true;

                }
                if (isAuthenticated)
                {
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return RedirectToAction("List", "Users");
                }
                return View("Login");
            }
        }
    }
}
