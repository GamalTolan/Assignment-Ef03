using Assignment_Ef03.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Ef03.Data.Db_Context
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInst> CoursesInstructors { get; set; }
        public DbSet<Topic> Topics { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-RB8GVLBO;database=ITIDB_2;trusted_connection=true;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.ID);

            modelBuilder.Entity<CourseInst>().HasKey(x=>new {x.InstID ,x.CourseID });

            modelBuilder.Entity<Instructor>()
                .HasOne(Instructor => Instructor.Department)
                .WithMany(x => x.Instructors);

            modelBuilder.Entity<Department>()
                        .HasMany(x => x.Instructors)
                        .WithOne(Department => Department.Department)
                        .HasForeignKey(x => x.Dept_ID); 






        }

    }
}
