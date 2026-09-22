using System;

namespace TrustID.Exceptions
{
    // Thrown whenever a business rule / input validation fails inside
    // the model or service layer. Forms catch this and show a
    // friendly MessageBox instead of letting the app crash.
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}
