using StudentInformationSystem.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.Student
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Required]
        public int Level { get; set; }


        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData { get; set; }

    }
}
