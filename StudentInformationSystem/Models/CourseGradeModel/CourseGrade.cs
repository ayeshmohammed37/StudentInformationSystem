using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models.CourseModel;
using StudentInformationSystem.Models.StudentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.CourseGradeModel
{
    public class CourseGrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseGradeID { get; set; }

        public Grade Grade { get; set; }
        public DateTime CourseStartDate { get; set; }
        public DateTime CourseEndDate { get; set; }

        public int StudentID { get; set; }

        public int CourseID { get; set; }

        //Navigation Properties
        [ForeignKey(nameof(StudentID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Student? Student { get; set; } = null;

        [ForeignKey(nameof(CourseID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Course? Course { get; set; } = null;
    }
}
