namespace StudentInformationSystem.Models.Shared
{

    //* City, Address, Home Tele,  Mobile, Email, Fax,  Mailbox
    public class ContactData
    {
        public ContactData(string city, string address, string homeTele, string mobile, string email, string fax, string mailBox)
        {
            City = city;
            Address = address;
            HomeTele = homeTele;
            Mobile = mobile;
            Email = email;
            Fax = fax;
            MailBox = mailBox;
        }

        public string City { get; set; }
        public string Address { get; set; }
        public string HomeTele { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string MailBox { get; set; }
    }
}
