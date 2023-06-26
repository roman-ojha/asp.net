using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Lab_04_StateManagement.Pages.Users
{
    public class InsertStudentModel : PageModel
    {
        [BindProperty]
        [Required]
        public string FirstName { get; set; } = String.Empty;

        [BindProperty]
        [Required]
        public string LastName { get; set; } = String.Empty;

        [BindProperty]
        [Required]
        public string Email { get; set; } = String.Empty;




        public void OnGet()
        {
        }

        public void OnPost()
        {
            // Store inside session
            HttpContext.Session.SetString("FirstName", FirstName);
            HttpContext.Session.SetString("LastName", LastName);
            HttpContext.Session.SetString("Eamil", Email);

            // Store inside Cookie
            Response.Cookies.Append("FirstName", FirstName);
            Response.Cookies.Append("LastName", LastName);
            Response.Cookies.Append("Email", Email);
        }
    }
}
