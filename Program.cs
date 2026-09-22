using TrustID.Models;
using TrustID.Services;

namespace user_dashboard
{
    internal static class Program
    {
        public static UserManager SharedUserManager = new UserManager();
        public static VerificationManager SharedVerificationManager = new VerificationManager();
        public static ReviewManager SharedReviewManager = new ReviewManager();
        public static User? CurrentUser;

        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();

            SharedUserManager.LoadAllUsers(
                Path.Combine(Application.StartupPath, "trustid_users.dat")
            );

            string verificationPath = Path.Combine(
                Application.StartupPath,
                "verification_requests.txt");

            SharedVerificationManager.SetPersistenceFile(
                verificationPath);

            SharedVerificationManager.LoadRequests(
                verificationPath,
                SharedUserManager);
            SharedUserManager.SynchronizeQualificationContributions();

            SharedReviewManager.SetPersistenceFile(
                Path.Combine(Application.StartupPath, "reviews.txt")
            );

            SharedReviewManager.LoadReviews(
                Path.Combine(Application.StartupPath, "reviews.txt"),
                SharedUserManager
            );

            EnsureDefaultAdminExists();

            Application.Run(new frmLogin());
        }        private static void EnsureDefaultAdminExists()
        {
            bool adminExists = SharedUserManager.Users.Any(u => u.CanAccessAdminFunctions());
            if (!adminExists)
            {
                try
                {
                    var admin = new Administrator("Admin User", "admin@trustid.io", "admin", "Password1", "System Administrator");
                    SharedUserManager.Register(admin);
                }
                catch (TrustID.Exceptions.ValidationException) { }
            }
        }
    }
}