using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages;
public class AssignmentQ1 : PageModel
{
    [BindProperty]
    [Required]
    [Display(Name = "Number 1: ")]
    public int Number1 { get; set; }

    [BindProperty]
    [Required]
    [Display(Name = "Number 2: ")]
    public int Number2 { get; set; }

    public int Sum { get; set; }
    public int Subtract { get; set; }
    public int Multiply { get; set; }
    public int Divide { get; set; }

    public string CurrentOperation { get; set; } = "";

    public void OnPost()
    {
        if (Request.Form.ContainsKey("add"))
        {
            // name attribute with 'add' value get clicked
            Sum = Number1 + Number2;
            CurrentOperation = "Sum";
        }
        else if (Request.Form.ContainsKey("subtract"))
        {
            Subtract = Number1 - Number2;
            CurrentOperation = "Subtract";
        }
        else if (Request.Form.ContainsKey("multiply"))
        {
            Multiply = Number1 * Number2;
            CurrentOperation = "Multiply";
        }
        else if (Request.Form.ContainsKey("divide"))
        {
            if (Number2 != 0)
                Divide = Number1 / Number2;
            CurrentOperation = "Divide";
        }
    }
}
