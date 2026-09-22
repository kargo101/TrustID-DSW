using TrustID.Exceptions;
using TrustID.Models;

namespace TrustID.Services
{
    // Tracks who is currently logged into the running application.
    // A single instance of this is shared across forms (e.g. created
    // once in Program.cs / frmAdminDashboard and passed around, or
    // exposed as a simple singleton like below for a student project).
    public class AuthenticationManager
    {
        private static AuthenticationManager _instance;

        public static AuthenticationManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AuthenticationManager();
                return _instance;
            }
        }

        private AuthenticationManager() { }

        public User CurrentUser { get; private set; }

        public bool IsLoggedIn
        {
            get { return CurrentUser != null; }
        }

        public void SetCurrentUser(User user)
        {
            if (user == null)
                throw new ValidationException("Cannot start a session without a logged-in user.");
            CurrentUser = user;
        }

        // Called by the Logout button. Clears the session; the Form
        // decides what happens next (close app, show login screen, etc).
        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
