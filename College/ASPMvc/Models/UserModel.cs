using Microsoft.AspNetCore.Mvc;

namespace ASPMvc.Models
{
    public class UserModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
    }
}
