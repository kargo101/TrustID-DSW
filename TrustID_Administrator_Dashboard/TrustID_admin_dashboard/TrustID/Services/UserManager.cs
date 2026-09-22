using System;
using System.Collections.Generic;
using System.Linq;
using TrustID.Exceptions;
using TrustID.Models;

namespace TrustID.Services
{
    // Owns the in-memory user list and every operation that touches it.
    // Forms call into this instead of manipulating a List<User> directly.
    public class UserManager
    {
        private readonly List<User> _users = new List<User>();

        public IReadOnlyList<User> Users
        {
            get { return _users.AsReadOnly(); }
        }

        public User Register(User newUser)
        {
            if (newUser == null)
                throw new ValidationException("No user data was provided.");

            // Duplicate username/email
            if (_users.Any(u => u.Username.Equals(newUser.Username, StringComparison.OrdinalIgnoreCase)))
                throw new ValidationException("That username is already taken.");

            if (_users.Any(u => u.Email.Equals(newUser.Email, StringComparison.OrdinalIgnoreCase)))
                throw new ValidationException("An account already exists with that email address.");

            _users.Add(newUser);
            return newUser;
        }

        // Invalid login
        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Username and password are required.");

            User user = _users.FirstOrDefault(u =>
                u.Username.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null || !user.VerifyPassword(password))
                throw new ValidationException("Incorrect username or password.");

            if (user.AccountStatus == AccountStatus.Suspended)
                throw new ValidationException("This account has been suspended. Contact support for assistance.");

            return user;
        }

        // Unauthorized access to administrator functions
        public void RequireAdministrator(User user)
        {
            if (user == null || !user.CanAccessAdminFunctions())
                throw new ValidationException("You do not have permission to access administrator functions.");
        }

        // Search returning no users is handled by the caller checking
        // Count == 0 on the result - this never throws for an empty result,
        // since "no matches" is a normal, valid outcome, not an error.
        public List<User> SearchUsers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return _users.ToList();

            string term = searchTerm.Trim().ToLower();
            return _users.Where(u =>
                u.FullName.ToLower().Contains(term) ||
                u.Email.ToLower().Contains(term) ||
                u.Username.ToLower().Contains(term)
            ).ToList();
        }

        public User GetById(int userId)
        {
            User user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user == null)
                throw new ValidationException("No user was found with that ID.");
            return user;
        }

        public void SuspendUser(int userId)
        {
            User user = GetById(userId);
            user.AccountStatus = AccountStatus.Suspended;
        }

        public void ReactivateUser(int userId)
        {
            User user = GetById(userId);
            user.AccountStatus = AccountStatus.Active;
        }
    }
}
