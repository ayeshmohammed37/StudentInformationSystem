using StudentInformationSystem.Models.CourseModel;
using StudentInformationSystem.Models.DepartmentModel;
using StudentInformationSystem.Models.Shared;
using StudentInformationSystem.Models.StudentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.StaffModel
{
    public class Staff: Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }
        public String Degree { get; set; }

        public string Office { get; set; }

        //Navigation Properties

        public virtual List<Student>? Students { get; set; } = new List<Student>();

        public virtual Department? Department { get; set; } = null;

        public virtual List<Course>? Courses { get; set; } = new List<Course>();
    }
}
