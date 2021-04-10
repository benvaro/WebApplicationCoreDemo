using Microsoft.EntityFrameworkCore;

namespace FilmsApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions option) : base(option)
        {
            Database.EnsureCreated();
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Film> Films { get; set; }
    }
}
