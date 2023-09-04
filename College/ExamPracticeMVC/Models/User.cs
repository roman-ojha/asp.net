using System.ComponentModel.DataAnnotations;

namespace ExamPracticeMVC.Models
{
    public class User
    {
        [Required(ErrorMessage ="FirstName is required")]
        [Display(Name ="First Name")]
        [StringLength(50, MinimumLength =5)]
        public String FirstName { get; set; }


        [Required(ErrorMessage ="LastName is required")]
        [Display(Name ="Last Name")]
        [StringLength(50, MinimumLength =5)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        public String Email { get; set; }
    }
}
