using StudentInformationSystem.Models.Shared;

namespace StudentInformationSystem.Models.Student
{
    public class Student
    {

        public int StudentID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData { get; set; }
    }
}
