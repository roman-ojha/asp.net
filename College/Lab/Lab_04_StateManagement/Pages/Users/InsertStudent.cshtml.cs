using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

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

        }
    }
}
