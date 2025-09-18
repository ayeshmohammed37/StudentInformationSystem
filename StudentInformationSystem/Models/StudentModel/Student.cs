using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models.CourseGradeModel;
using StudentInformationSystem.Models.DepartmentModel;
using StudentInformationSystem.Models.Shared;
using StudentInformationSystem.Models.StaffModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.StudentModel
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        public int Level { get; set; }


        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData { get; set; }

        //Navigation Properties

        public int? DepartmentID { get; set; }
        public int? StaffID { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Department? Department { get; set; } = null;

        [ForeignKey(nameof(StaffID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Staff? Advisor { get; set; } = null;

        public virtual List<CourseGrade>? CourseGrades { get; set; } = new List<CourseGrade>();

    }
}
