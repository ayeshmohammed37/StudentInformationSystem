using StudentInformationSystem.Models.Shared;

namespace StudentInformationSystem.Models.StaffModel
{
    public class Staff
    {
        public int StaffID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData{ get; set; }

        public PreQualifications PreQualifications { get; set; }

    }
}
