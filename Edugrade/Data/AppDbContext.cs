using Edugrade.Models;
using Microsoft.EntityFrameworkCore;

namespace Edugrade.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<SchoolClass>().HasData(
                new SchoolClass { Id = 1, ClassName = "Net22" },
                new SchoolClass { Id = 2, ClassName = "Net23" },
                new SchoolClass { Id = 3, ClassName = "Net24" });


            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Programmering 1" },
                new Course { Id = 2, Name = "Programmering 2" },
                new Course { Id = 3, Name = "Programmering 3" },
                new Course { Id = 4, Name = "Frontend" },
                new Course { Id = 5, Name = "React" },
                new Course { Id = 6, Name = "Sql Databaser" },
                new Course { Id = 7, Name = "Asp.Net" },
                new Course { Id = 8, Name = "DevOps" },
                new Course { Id = 9, Name = "Agila Metoder" });


            base.OnModelCreating(modelBuilder);
        }

    }
}
