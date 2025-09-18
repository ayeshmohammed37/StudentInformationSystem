using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Models.CourseGradeModel;
using StudentInformationSystem.Models.DepartmentModel;
using StudentInformationSystem.Models.StudentModel;
using StudentInformationSystem.ViewModels;

namespace StudentInformationSystem.Controllers
{
    public class StudentPortalController : Controller
    {
        SISDbContext context = new SISDbContext();
        public IActionResult Index()
        {
            var students = context.Students.ToList();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            Student student = context.Students.FirstOrDefault(s => s.ID == id);

            Department department = context.Departments.FirstOrDefault(d => d.DepartmentID == id);

            List<CourseGrade> courseGrades = context.CourseGrades.Where(cg => cg.StudentID == id).Include(course => course.Course).ToList();

            StudentDetailsVM studentDetails = new StudentDetailsVM(student, department, courseGrades);

            return View(studentDetails);
        }
    }
}
