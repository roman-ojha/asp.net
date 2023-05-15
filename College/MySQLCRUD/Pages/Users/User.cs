using System.ComponentModel.DataAnnotations;

namespace MySQLCRUD.Pages.Users
{
    public class User // Model name needs to be same as Table name
    {
        [Key]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}