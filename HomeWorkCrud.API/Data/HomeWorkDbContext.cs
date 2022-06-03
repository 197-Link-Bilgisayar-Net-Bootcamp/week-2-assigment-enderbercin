using HomeWorkCrud.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWorkCrud.API.Data
{
    public class HomeWorkDbContext:DbContext
    {
        public HomeWorkDbContext(DbContextOptions<HomeWorkDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
