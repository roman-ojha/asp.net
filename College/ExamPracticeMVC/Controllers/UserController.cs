using Microsoft.AspNetCore.Mvc;
using ExamPracticeMVC.Models;
using ExamPracticeMVC.Services;
using System.Data.SqlClient;

namespace ExamPracticeMVC.Controllers
{
    public class UserController : Controller
    {

        private ILog _log;

        public UserController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index()
        {
            // return Content("This is User Page");
            ViewData["Name"] = "Roman Ojha";
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            Console.WriteLine(user);
            if (ModelState.IsValid)
                return Content("Valid user");
            else
                return View(user);
        }

        [HttpPost]
        public IActionResult GetUser(User user)
        {
            _log.info("This is from GetUser Action");
            if (ModelState.IsValid)
                return Content("Valid user");
            else
                return View("Index",user);
        }

        public IActionResult ReadUser()
        {
            string connStr = "Data Source=localhost;Initial Catalog=college_dotnet_exam;User ID=root;Password=";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "INSERT INTO user values ('roman', 'ojha', 'razz@gmail.com')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            return Redirect("/User");
        }
    }
}
