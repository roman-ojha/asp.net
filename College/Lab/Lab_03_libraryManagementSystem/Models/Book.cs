using System.ComponentModel.DataAnnotations;

namespace libraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
        public string Publication { get; set; }
    }
}
