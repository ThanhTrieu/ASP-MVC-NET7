using Microsoft.EntityFrameworkCore;

namespace Tranning.DBContext
{
    public class TrainerTestDBContext : DbContext
    {
        public TrainerTestDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TrainerTestRoles> Roles { get; set; }
    }
}
