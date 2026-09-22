namespace TrustID.Models
{
    public class Administrator : User
    {
        public string Role { get; set; } // e.g. "Verification Specialist", "Business Admin"

        public Administrator(string fullName, string email, string username, string password, string role)
            : base(fullName, email, username, password)
        {
            Role = role;
            // Administrators are trusted immediately - no verification queue for staff.
            VerificationStatus = VerificationStatus.Verified;
            AccountStatus = AccountStatus.Active;
        }

        public override string GetUserTypeLabel()
        {
            return "Administrator";
        }

        // Polymorphism: only Administrators can access admin functions.
        public override bool CanAccessAdminFunctions()
        {
            return true;
        }
    }
}
