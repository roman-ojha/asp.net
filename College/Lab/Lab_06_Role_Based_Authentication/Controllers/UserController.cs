using Microsoft.AspNetCore.Mvc;

namespace Lab_06_Role_Based_Authentication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
