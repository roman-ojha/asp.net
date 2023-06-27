using Microsoft.AspNetCore.Mvc;
using ASPMvc.Models;

namespace ASPMvc.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            ViewBag.Message = "Welcome"; // passing data into view
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            // using this method for post method
            int n1 = Convert.ToInt32(form["Num1"]);
            int n2 = Convert.ToInt32(form["Num2"]);
            int sum = n1 + n2; // adding submitted data

            ViewBag.Result = "Sum = " + sum; // passing into view
            return View(); // Redirecting to "Create" Action
        }

	public IActionResult Add()
        {
            ViewBag.Message = "Welcome";
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserModel form)
        {
/*	        int n1 = user.Number1;
	        int n2 = user.Number2;
            int sum = n1 + n2;
  	        ViewBag.Result = "Sum = "+sum;*/
            // using this method for post method
            return View();
        }


    }
}
