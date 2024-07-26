using Microsoft.EntityFrameworkCore;
using StudentAPI_V1.Models;

namespace StudentAPI_V1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
