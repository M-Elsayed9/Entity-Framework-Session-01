using Assignment.Configurations;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace Assignment.Context
{
    internal class ITIDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMED_PC; Database = ITI-EF; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfig());
            modelBuilder.ApplyConfiguration<Instructor>(new InstructorConfig());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfig());

            modelBuilder.Entity<CourseInstructor>(CI =>
            {
                CI.HasKey(CI => new { CI.Course_Id, CI.InsId });
                CI.Property(CI => CI.Evaluate).HasColumnType("int");
            });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });
            modelBuilder.Entity<StudentCourse>().Property(SC => SC.Grade).HasColumnType("int");

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
