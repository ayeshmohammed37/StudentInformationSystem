using StudentInformationSystem.Models.CourseGradeModel;
using StudentInformationSystem.Models.DepartmentModel;
using StudentInformationSystem.Models.StudentModel;

namespace StudentInformationSystem.ViewModels
{
    public class StudentDetailsVM
    {
        public StudentDetailsVM(Student student, Department department, List<CourseGrade> courseGrades)
        {
            Student = student;
            Department = department;
            CourseGrades = courseGrades;
        }

        public Student Student { get; set; }
        public Department Department { get; set; }

        public List<CourseGrade> CourseGrades { get; set; }
    }
}
