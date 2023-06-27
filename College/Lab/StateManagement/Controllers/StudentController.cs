using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace StateManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Insert()
        {
         return View();
        }

        [HttpPost]
        public IActionResult StoreStudent(string fname, string lname, string email, string store_into)
        {
            if(store_into == "session")
            {
                // Store inside session
                HttpContext.Session.SetString("FirstName", fname);
                HttpContext.Session.SetString("LastName", lname);
                HttpContext.Session.SetString("Email", email);
                return RedirectToAction("ShowSession");
            }
            else if(store_into == "cookie")
            {
                // Store inside Cookie
                Response.Cookies.Append("FirstName", fname);
                Response.Cookies.Append("LastName", lname);
                Response.Cookies.Append("Email", email);
                return RedirectToAction("ShowCookie");
            }
            else if(store_into == "query_string")
            {
                return RedirectToAction("ShowQueryString", new { fname = fname, lname = lname, email = email });
            }
            else if(store_into == "view_data")
            {
                // Pass data using ViewData
                ViewData["FirstName"] = fname;
                ViewData["LastName"] = lname;
                ViewData["Email"] = email;
                return View("ShowViewData");
            }
            return RedirectToAction("Insert");
        }

        public IActionResult ShowSession()
        {
            return View();
        }

        public IActionResult ShowCookie()
        {
            return View();
        }

        public IActionResult ShowQueryString()
        {
            return View();
        }

        public IActionResult ShowViewData()
        {
            return View();
        }
    }
}
