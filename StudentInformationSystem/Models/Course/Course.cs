namespace StudentInformationSystem.Models.Course
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHours { get; set; }
        public CourseType CourseType { get; set; }
        public Requirment Requirment { get; set; }
        public int Level { get; set; }
        public List<Course> Prerequisites { get; set; }

    }


}
