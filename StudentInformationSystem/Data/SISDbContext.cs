using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models.AdministratorModel;
using StudentInformationSystem.Models.CourseGradeModel;
using StudentInformationSystem.Models.CourseModel;
using StudentInformationSystem.Models.DepartmentCourseModel;
using StudentInformationSystem.Models.DepartmentModel;
using StudentInformationSystem.Models.Shared;
using StudentInformationSystem.Models.StaffModel;
using StudentInformationSystem.Models.StudentModel;

namespace StudentInformationSystem.Data
{
    public class SISDbContext: DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentCourse> DepartmentCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseGrade> CourseGrades { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SIS;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
            //modelBuilder.Entity<Student>().ToTable("Students");
            //modelBuilder.Entity<Staff>().ToTable("Staffs");
            //modelBuilder.Entity<Administrator>().ToTable("Administrators");

            modelBuilder.Entity<Course>(course =>
            {
                course.HasMany(c => c.Prerequisites)
                .WithMany(c => c.IsPrerequisiteFor);
            });



            base.OnModelCreating(modelBuilder);
        }
    }
}
