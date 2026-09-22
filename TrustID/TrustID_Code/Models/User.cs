using System;
using System.Text.RegularExpressions;
using TrustID.Exceptions;

namespace TrustID.Models
{
    // Abstract base for every account type in the system.
    // IndividualUser, BusinessUser and Administrator all inherit from
    // this so shared behaviour (validation, trust score, status) lives
    // in exactly one place.
    public abstract class User
    {
        private static int _nextId = 1000;

        private string _fullName;
        private string _email;
        private string _username;
        private string _passwordHash;

        public int UserId { get; private set; }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = ValidateFullName(value); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = ValidateEmail(value); }
        }

        public string Username
        {
            get { return _username; }
            set { _username = ValidateUsername(value); }
        }

        public VerificationStatus VerificationStatus { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public DateTime JoinedDate { get; private set; }
        public Reputation TrustScore { get; private set; }

        // Every user type must say what it's called in the UI
        // ("Individual", "Business", "Administrator") - this is the
        // polymorphism hook the Forms use instead of type-checking.
        public abstract string GetUserTypeLabel();

        // Different account types can restrict what they're allowed to
        // do in the system - overridden per subclass where relevant.
        public virtual bool CanAccessAdminFunctions()
        {
            return false;
        }

        protected User(string fullName, string email, string username, string password)
        {
            UserId = _nextId++;
            FullName = fullName;
            Email = email;
            Username = username;
            SetPassword(password);
            VerificationStatus = VerificationStatus.Unverified;
            AccountStatus = AccountStatus.Pending;
            JoinedDate = DateTime.Now;
            TrustScore = new Reputation();
        }

        public void SetPassword(string password)
        {
            _passwordHash = HashPassword(ValidatePassword(password));
        }

        public bool VerifyPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            return _passwordHash == HashPassword(password);
        }

        // ---- Persistence support ----
        // These two exist ONLY so UserManager can save/load accounts
        // across app restarts without ever seeing a plaintext password.
        // GetPasswordHash returns the already-hashed value (safe to write
        // to a file). RestorePasswordHash sets it directly, skipping
        // validation/re-hashing - used only when reading a user back in
        // from a file that already stored the hash.
        public string GetPasswordHash()
        {
            return _passwordHash;
        }

        public void RestorePasswordHash(string hash)
        {
            _passwordHash = hash;
        }

        public void RestoreJoinedDate(DateTime date)
        {
            JoinedDate = date;
        }

        private static string HashPassword(string password)
        {
            // Placeholder hash for a student/prototype project.
            // In a real system this would use a salted algorithm
            // such as PBKDF2, bcrypt or Argon2 - never store plain text.
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // ---- Validation (Empty fields / invalid email / weak password) ----

        private static string ValidateFullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException("Full name cannot be empty.");
            return value.Trim();
        }

        private static string ValidateEmail(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException("Email address cannot be empty.");

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(value.Trim(), pattern))
                throw new ValidationException("Please enter a valid email address.");

            return value.Trim().ToLower();
        }

        private static string ValidateUsername(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException("Username cannot be empty.");
            if (value.Trim().Length < 3)
                throw new ValidationException("Username must be at least 3 characters long.");
            return value.Trim();
        }

        private static string ValidatePassword(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException("Password cannot be empty.");
            if (value.Length < 8)
                throw new ValidationException("Password must be at least 8 characters long.");
            if (!Regex.IsMatch(value, "[A-Z]"))
                throw new ValidationException("Password must contain at least one uppercase letter.");
            if (!Regex.IsMatch(value, "[0-9]"))
                throw new ValidationException("Password must contain at least one number.");
            return value;
        }
    }
}