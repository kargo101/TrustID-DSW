namespace TrustID.Models
{
    public class IndividualUser : User
    {
        public string Occupation { get; set; }

        public IndividualUser(string fullName, string email, string username, string password, string occupation)
            : base(fullName, email, username, password)
        {
            Occupation = occupation;
        }

        public override string GetUserTypeLabel()
        {
            return "Individual";
        }
    }
}
