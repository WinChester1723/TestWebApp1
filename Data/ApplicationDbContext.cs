using Microsoft.EntityFrameworkCore;
using TestWebApp1.Models;

namespace TestWebApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
    }
}
