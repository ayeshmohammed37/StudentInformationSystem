namespace StudentInformationSystem.Models.Shared
{
    public class PreQualifications
    {
        public PreQualifications(string degree, string office, string university)
        {
            Degree = degree;
            Office = office;
            University = university;
        }

        public String Degree { get; set; }

        public string Office { get; set; }

        public string University { get; set; }
    }
}
