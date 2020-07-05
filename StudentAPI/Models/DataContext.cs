using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        { }
        public DbSet<Student> Students { get; set; }
    }
}
