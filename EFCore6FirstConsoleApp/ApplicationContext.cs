using Microsoft.EntityFrameworkCore;

namespace EFCore6FirstConsoleApp
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users => Set<User>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EFCore6FirstConsoleApp.db");
        }
    }
}
