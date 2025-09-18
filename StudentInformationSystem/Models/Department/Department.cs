namespace StudentInformationSystem.Models.Department
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public DateTime StartDate { get; set; }


        //DepartmentHeadID forign key for the instructor

    }
}
