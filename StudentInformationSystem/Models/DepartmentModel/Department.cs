using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models.DepartmentCourseModel;
using StudentInformationSystem.Models.StaffModel;
using StudentInformationSystem.Models.StudentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.DepartmentModel
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }

        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public DateTime StartDate { get; set; }

        public int? DepartmentHeadID { get; set; }

        //Navigation Properties
        public virtual List<Student>?  Students { get; set; } = new List<Student>();

        [ForeignKey(nameof(DepartmentHeadID))]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Staff? DepartmentHead { get; set; } = null;


        public virtual List<DepartmentCourse>? DepartmentCourses { get; set; } = new List<DepartmentCourse>();





    }
}
