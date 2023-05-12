using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages;

public class User
{
    public string Name { get; set; }
    public string PhotoName { get; set; }
    public User(string n, string p)
    {
        Name = n;
        PhotoName = p;
    }
}

public class AssignmentQ2 : PageModel
{
    [BindProperty]
    [Required]
    [Display(Name = "Name: ")]
    public string[] Names { get; set; } = new string[5];

    [BindProperty]
    [Required]
    [Display(Name = "Photo: ")]
    public List<User> Users { get; set; } = new List<User>();
    public async Task<IActionResult> OnPostAsync(IFormFile f)
    {
        foreach (var name in Names)
        {
            Console.WriteLine(name);
        }
        var files = Request.Form.Files;
        int i = 0;
        foreach (var file in files)
        {
            Console.WriteLine(file.FileName);
            if (file.Length > 0)
            {
                var filePath = Path.Combine("wwwroot\\assets\\files", file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                User user = new User(Names[i], file.FileName);
                Users.Add(user);
                i++;
            }
        }
        return Page();
    }
}