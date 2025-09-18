namespace StudentInformationSystem.Models.Shared
{

    public class PersonalInfo
    {
        
        public PersonalInfo(string firstName, string middleName, string lastName, string code, string iDNumber, Gender gender, string nationality, DateOnly birthDate, string birthPlace)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Code = code;
            IDNumber = iDNumber;
            Gender = gender;
            Nationality = nationality;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
        public string IDNumber { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public DateOnly BirthDate { get; set; }
        public string BirthPlace { get; set; }
    }
}
