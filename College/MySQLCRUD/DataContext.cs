// Install packages to integrate MySQL
// dotnet add package MySql.Data.EntityFrameworkCore
// dotnet add package MySql.Data

using Microsoft.EntityFrameworkCore;
// including User
using MySQLCRUD.Pages.Users;

namespace MySQLCRUD
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> user { get; set; }

    }
}
