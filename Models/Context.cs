using Microsoft.EntityFrameworkCore;
using prueba_tecnica.Models;

namespace prueba_tecnica.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<prueba_tecnica.Models.Province> Province { get; set; } = default!;
        public DbSet<prueba_tecnica.Models.Region> Region { get; set; } = default!;
    }
}
