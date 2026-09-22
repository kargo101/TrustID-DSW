using System;
using TrustID.Exceptions;

namespace TrustID.Models
{
    public class Qualification
    {
        private static int _nextId = 1;

        public int QualificationId { get; private set; }
        public User Owner { get; private set; }
        public string Title { get; private set; }
        public string IssuingBody { get; private set; }
        public DateTime IssueDate { get; private set; }
        public QualificationStatus Status { get; set; }

        public Qualification(User owner, string title, string issuingBody, DateTime issueDate)
        {
            if (owner == null)
                throw new ValidationException("A qualification must belong to a user.");
            if (string.IsNullOrWhiteSpace(title))
                throw new ValidationException("Qualification title cannot be empty.");
            if (string.IsNullOrWhiteSpace(issuingBody))
                throw new ValidationException("Issuing body cannot be empty.");
            if (issueDate > DateTime.Now)
                throw new ValidationException("Issue date cannot be in the future.");

            QualificationId = _nextId++;
            Owner = owner;
            Title = title.Trim();
            IssuingBody = issuingBody.Trim();
            IssueDate = issueDate;
            Status = QualificationStatus.Unverified;
        }
    }
}
