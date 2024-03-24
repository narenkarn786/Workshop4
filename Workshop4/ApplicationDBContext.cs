using Microsoft.EntityFrameworkCore;

namespace Workshop4
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
