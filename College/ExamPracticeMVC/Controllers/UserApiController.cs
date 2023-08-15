using Microsoft.AspNetCore.Mvc;
using ExamPracticeMVC.Models;

namespace ExamPracticeMVC.Controllers
{
    [ApiController]
    [Route("api/user/[controller]")]
    public class UserApiController : ControllerBase
    {

        private readonly User user = new User() { FirstName = "Roman" ,
            LastName = "Ojha",
            Email="razzroman@gmail.com"
        };
        public User Index()
        {
            return user;
        }
    }
}
