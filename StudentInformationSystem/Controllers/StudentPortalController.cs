using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;

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
    }
}
