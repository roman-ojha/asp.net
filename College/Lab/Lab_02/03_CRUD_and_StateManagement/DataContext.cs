using Microsoft.EntityFrameworkCore;
using _03_CRUD_and_StateManagement.Models;

namespace _03_CRUD_and_StateManagement
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> user { get; set; }
    }
}
