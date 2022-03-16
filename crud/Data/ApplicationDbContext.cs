using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options){ }
        public DbSet<Category> categories { get; set; }
    }
}
