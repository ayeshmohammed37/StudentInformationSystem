using StudentInformationSystem.Models.Shared;

namespace StudentInformationSystem.Models.Administrator
{
    public class Administrator
    {
        public int AdminID { get; set; }

        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData { get; set; }
    }
}
