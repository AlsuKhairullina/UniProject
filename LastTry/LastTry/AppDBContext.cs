using Microsoft.EntityFrameworkCore;
using LastTry.Models;

namespace LastTry
{
    public class AppDBContext: DbContext
    {
        public DbSet<Vacancies> Vacancies { get; set; }
        
        public DbSet<User> User { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
    }
}