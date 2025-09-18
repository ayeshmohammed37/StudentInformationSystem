using StudentInformationSystem.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Models.AdministratorModel
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdminID { get; set; }


        public PersonalInfo PersonalInfo { get; set; }

        public ContactData ContactData { get; set; }
    }
}
