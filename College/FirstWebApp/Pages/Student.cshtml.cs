using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages;

public class StudentModel : PageModel
{
    [BindProperty]
    [Required]
    [Display(Name = "Enter first number")]
    public int Num1 { get; set; }
    // Binding property with the asp-for attribute in html
    [BindProperty]
    // is the required field
    [Required]
    // Display(<attribute_name> = <value>)
    [Display(Name = "Enter second number")]
    public int Num2 { get; set; }
    public int Sum { get; set; }

    public void OnGet()
    {
    }

    // on post method
    public void OnPost()
    {
        Sum = Num1 + Num2;
    }
}

