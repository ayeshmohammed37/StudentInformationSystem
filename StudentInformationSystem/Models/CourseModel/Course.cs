using StudentInformationSystem.Models.CourseGradeModel;
using StudentInformationSystem.Models.DepartmentCourseModel;
using StudentInformationSystem.Models.StaffModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.CourseModel
{
    public class Course
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public CourseType CourseType { get; set; }
        public Requirment Requirment { get; set; }
        public int Level { get; set; }


        //Navigations Properties
        public virtual List<CourseGrade>? CourseGrades { get; set; } = new List<CourseGrade>();

        public virtual List<DepartmentCourse>? DepartmentCourses { get; set; } = new List<DepartmentCourse>();

        public virtual List<Staff> Staffs { get; set; } = new List<Staff>();


        //public ICollection<Course> Prerequisites { get; set; }
        //public ICollection<Course> IsPrerequisiteFor { get; set; }

        //public Course()
        //{
        //    Prerequisites = new HashSet<Course>();
        //    IsPrerequisiteFor = new HashSet<Course>();
        //}

    }


}
