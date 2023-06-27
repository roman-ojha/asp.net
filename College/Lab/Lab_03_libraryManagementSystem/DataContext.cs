using Microsoft.EntityFrameworkCore;
using libraryManagementSystem.Models;

namespace libraryManagementSystem
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Book> book { get; set; }
    }
}
