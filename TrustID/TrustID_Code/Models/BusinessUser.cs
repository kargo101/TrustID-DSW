using TrustID.Exceptions;

namespace TrustID.Models
{
    public class BusinessUser : User
    {
        private string _registrationNumber;

        public string BusinessName { get; set; }

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ValidationException("Business registration number cannot be empty.");
                _registrationNumber = value.Trim();
            }
        }

        public BusinessUser(string fullName, string email, string username, string password,
                             string businessName, string registrationNumber)
            : base(fullName, email, username, password)
        {
            BusinessName = businessName;
            RegistrationNumber = registrationNumber;
        }

        public override string GetUserTypeLabel()
        {
            return "Business";
        }
    }
}
