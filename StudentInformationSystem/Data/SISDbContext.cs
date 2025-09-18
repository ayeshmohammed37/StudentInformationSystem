using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models.CourseModel;

namespace StudentInformationSystem.Data
{
    public class SISDbContext: DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(course =>
            {
                course.HasMany(c => c.Prerequisites)
                .WithMany(c => c.IsPrerequisiteFor);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
