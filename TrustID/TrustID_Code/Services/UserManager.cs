using TrustID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using TrustID.Exceptions;

namespace TrustID.Services
{
    // Owns the in-memory user list and every operation that touches it.
    // Forms call into this instead of manipulating a List<User> directly.
    public class UserManager
    {
        private readonly List<User> _users = new List<User>();
        private string? _persistenceFilePath = null;

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
            AutoSave();
            return newUser;
        }

        // Invalid login
        public User Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ValidationException("Email/username and password are required.");

            User user = _users.FirstOrDefault(u =>
                u.Username.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) ||
                u.Email.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null || !user.VerifyPassword(password))
                throw new ValidationException("Incorrect email, username or password.");

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

            AutoSave();
        }

        public void ReactivateUser(int userId)
        {
            User user = GetById(userId);

            user.AccountStatus = AccountStatus.Active;

            AutoSave();
        }

        // Used by the "Change Password" flow that happens BEFORE login.
        public void ResetPassword(string username, string newPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ValidationException("Email address or username is required.");

            User user = _users.FirstOrDefault(u =>
                u.Username.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) ||
                u.Email.Equals(username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null)
                throw new ValidationException("No account was found with that email address or username.");

            user.SetPassword(newPassword);

            AutoSave();
        }

        // ============================================================
        // FILE-BASED SHARING WITH THE USER DASHBOARD SIDE
        // ============================================================

        public void LoadUsersFromFile(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
                return;

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length != 5)
                    continue;

                string fullName = $"{parts[0]} {parts[1]}";
                string plainPassword = parts[2];
                string email = parts[4];

                bool alreadyExists = _users.Any(u =>
                    u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

                if (alreadyExists)
                    continue;

                try
                {
                    var user = new IndividualUser(
                        fullName,
                        email,
                        email,
                        plainPassword,
                        "Unspecified"
                    );

                    user.VerificationStatus = VerificationStatus.Verified;
                    user.AccountStatus = AccountStatus.Active;

                    _users.Add(user);
                }
                catch (ValidationException)
                {
                    continue;
                }
            }
        }

        // ============================================================
        // SUSPENDED STATUS FILE
        // ============================================================

        public void SaveSuspendedStatusToFile(string filePath)
        {
            var lines = _users
                .Where(u => u.AccountStatus == AccountStatus.Suspended)
                .Select(u => $"{u.Email}|Suspended");

            System.IO.File.WriteAllLines(filePath, lines);
        }

        // ============================================================
        // REAL PERSISTENCE FOR TRUSTID ACCOUNTS
        // ============================================================

        private const char FieldSeparator = '\u001F';

        public void SaveAllUsers(string filePath)
        {
            var lines = new List<string>();

            foreach (User user in _users)
            {
                string typeTag;
                string extra1 = "";
                string extra2 = "";

                if (user is IndividualUser individual)
                {
                    typeTag = "Individual";
                    extra1 = individual.Occupation ?? "";
                }
                else if (user is BusinessUser business)
                {
                    typeTag = "Business";
                    extra1 = business.BusinessName ?? "";
                    extra2 = business.RegistrationNumber ?? "";
                }
                else if (user is Administrator admin)
                {
                    typeTag = "Administrator";
                    extra1 = admin.Role ?? "";
                }
                else
                {
                    continue;
                }

                // ----------------------------------------------------
                // TRUST SCORE CONTRIBUTIONS
                // ----------------------------------------------------
                // Stored as:
                //
                // Completed Transactions=15;Verification Approved=20
                //
                // This becomes the 12th field in the record.
                // ----------------------------------------------------

                List<string> contributionParts = new List<string>();

                foreach (var contribution in user.TrustScore.GetContributions())
                {
                    contributionParts.Add(
                        contribution.Key + "=" + contribution.Value
                    );
                }

                string contributions =
                    string.Join(";", contributionParts);

                string line = string.Join(
                    FieldSeparator.ToString(),
                    new[]
                    {
                        typeTag,
                        user.FullName,
                        user.Email,
                        user.Username,
                        user.GetPasswordHash(),
                        user.VerificationStatus.ToString(),
                        user.AccountStatus.ToString(),
                        user.JoinedDate.Ticks.ToString(),
                        extra1,
                        extra2,
                        user.TrustScore.CurrentScore.ToString(),
                        contributions
                    }
                );

                lines.Add(line);
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public void LoadAllUsers(string filePath)
        {
            _persistenceFilePath = filePath;

            if (!System.IO.File.Exists(filePath))
                return;

            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] p = line.Split(FieldSeparator);

                // Support:
                // 10 fields = original records
                // 11 fields = records with Trust Score
                // 12 fields = records with Trust Score + contributions
                if (p.Length != 10 &&
                    p.Length != 11 &&
                    p.Length != 12)
                {
                    continue;
                }

                string typeTag = p[0];
                string fullName = p[1];
                string email = p[2];
                string username = p[3];
                string passwordHash = p[4];
                string verificationStatus = p[5];
                string accountStatus = p[6];

                long joinedTicks;

                if (!long.TryParse(p[7], out joinedTicks))
                    continue;

                string extra1 = p[8];
                string extra2 = p[9];

                int savedTrustScore = 0;

                // Records with Trust Score contain field 11.
                if (p.Length >= 11)
                {
                    int.TryParse(p[10], out savedTrustScore);
                }

                // Skip if already loaded.
                if (_users.Any(u =>
                    u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                {
                    continue;
                }

                try
                {
                    User user;

                    const string placeholderPassword = "Placeholder1";

                    if (typeTag == "Individual")
                    {
                        user = new IndividualUser(
                            fullName,
                            email,
                            username,
                            placeholderPassword,
                            extra1
                        );
                    }
                    else if (typeTag == "Business")
                    {
                        user = new BusinessUser(
                            fullName,
                            email,
                            username,
                            placeholderPassword,
                            extra1,
                            extra2
                        );
                    }
                    else if (typeTag == "Administrator")
                    {
                        user = new Administrator(
                            fullName,
                            email,
                            username,
                            placeholderPassword,
                            extra1
                        );
                    }
                    else
                    {
                        continue;
                    }

                    // Restore real stored password hash.
                    user.RestorePasswordHash(passwordHash);

                    // Restore account state.
                    user.VerificationStatus =
                        (VerificationStatus)Enum.Parse(
                            typeof(VerificationStatus),
                            verificationStatus
                        );

                    user.AccountStatus =
                        (AccountStatus)Enum.Parse(
                            typeof(AccountStatus),
                            accountStatus
                        );

                    // Restore cumulative Trust Score.
                    user.TrustScore.RestoreScore(savedTrustScore);

                    // ------------------------------------------------
                    // RESTORE TRUST SCORE CONTRIBUTIONS
                    // ------------------------------------------------
                    // Only new 12-field records contain this data.
                    // Older users remain fully compatible.
                    // ------------------------------------------------

                    if (p.Length == 12 &&
                        !string.IsNullOrWhiteSpace(p[11]))
                    {
                        string[] contributionParts =
                            p[11].Split(';');

                        foreach (string contributionPart in contributionParts)
                        {
                            if (string.IsNullOrWhiteSpace(contributionPart))
                                continue;

                            int separatorIndex =
                                contributionPart.LastIndexOf('=');

                            if (separatorIndex <= 0)
                                continue;

                            string factor =
                                contributionPart
                                    .Substring(0, separatorIndex)
                                    .Trim();

                            string pointsText =
                                contributionPart
                                    .Substring(separatorIndex + 1)
                                    .Trim();

                            if (int.TryParse(
                                pointsText,
                                out int points))
                            {
                                user.TrustScore.RestoreContribution(
                                    factor,
                                    points
                                );
                            }
                        }
                    }

                    // Restore original joined date.
                    user.RestoreJoinedDate(
                        new DateTime(joinedTicks)
                    );

                    _users.Add(user);
                }
                catch (ValidationException)
                {
                    // Skip invalid records instead of crashing.
                    continue;
                }
                catch (ArgumentException)
                {
                    // Handles invalid enum values safely.
                    continue;
                }
            }
        }

        private void AutoSave()
        {
            if (_persistenceFilePath != null)
            {
                SaveAllUsers(_persistenceFilePath);
            }
        }

        public void SaveChanges()
        {
            AutoSave();
        }
        public void SynchronizeQualificationContributions()
        {
            string path = Path.Combine(
                Application.StartupPath,
                "qualifications.txt");

            if (!File.Exists(path))
                return;

            Dictionary<int, int> approvedContributions =
                new Dictionary<int, int>();

            Dictionary<int, int> rejectedContributions =
                new Dictionary<int, int>();

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');

                if (parts.Length < 8)
                    continue;

                string email = parts[1];

                User user = Users.FirstOrDefault(
                    u => u.Email.Equals(
                        email,
                        StringComparison.OrdinalIgnoreCase));

                if (user == null)
                    continue;

                if (!approvedContributions.ContainsKey(user.UserId))
                    approvedContributions[user.UserId] = 0;

                if (!rejectedContributions.ContainsKey(user.UserId))
                    rejectedContributions[user.UserId] = 0;

                string status = parts[7];

                if (status.Equals(
                        "Approved",
                        StringComparison.OrdinalIgnoreCase))
                {
                    approvedContributions[user.UserId] += 10;
                }
                else if (status.Equals(
                             "Rejected",
                             StringComparison.OrdinalIgnoreCase))
                {
                    rejectedContributions[user.UserId] -= 5;
                }
            }

            foreach (User user in Users)
            {
                int approved = 0;
                int rejected = 0;

                if (approvedContributions.ContainsKey(user.UserId))
                    approved = approvedContributions[user.UserId];

                if (rejectedContributions.ContainsKey(user.UserId))
                    rejected = rejectedContributions[user.UserId];

                user.TrustScore.RestoreContribution(
                    "Qualifications Approved",
                    approved);

                user.TrustScore.RestoreContribution(
                    "Qualifications Rejected",
                    rejected);

                int otherContributions = 0;

                foreach (var contribution in
                         user.TrustScore.GetContributions())
                {
                    if (contribution.Key != "Qualifications Approved" &&
                        contribution.Key != "Qualifications Rejected")
                    {
                        otherContributions += contribution.Value;
                    }
                }

                user.TrustScore.RestoreScore(
                    otherContributions + approved + rejected);
            }

            SaveChanges();
        }
    }
}