using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
