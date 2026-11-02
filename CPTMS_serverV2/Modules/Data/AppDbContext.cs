using CPTMS_serverV2.Modules.School.Entities;
using Microsoft.EntityFrameworkCore;

namespace CPTMS_serverV2.Modules.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Assignment> Assignment { get; set; } 
        public DbSet<Submission> Submissions { get; set; }

    }
}
