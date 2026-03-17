using Microsoft.EntityFrameworkCore;

namespace mvcCodeFirst.Models
{
    public partial class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
