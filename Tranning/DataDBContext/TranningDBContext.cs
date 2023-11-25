using Microsoft.EntityFrameworkCore;

namespace Tranning.DataDBContext
{
    public class TranningDBContext : DbContext
    {
        public TranningDBContext(DbContextOptions<TranningDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
