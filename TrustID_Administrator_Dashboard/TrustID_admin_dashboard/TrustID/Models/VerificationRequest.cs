using System;
using TrustID.Exceptions;

namespace TrustID.Models
{
    public class VerificationRequest
    {
        private static int _nextId = 1;

        public int RequestId { get; private set; }
        public User Applicant { get; private set; }
        public string DocumentType { get; private set; }
        public RequestPriority Priority { get; set; }
        public string AssignedSpecialist { get; set; }
        public RequestStatus Status { get; private set; }
        public DateTime SubmittedDate { get; private set; }
        public string RejectionReason { get; private set; }

        public VerificationRequest(User applicant, string documentType, RequestPriority priority)
        {
            if (applicant == null)
                throw new ValidationException("A verification request must belong to a user.");
            if (string.IsNullOrWhiteSpace(documentType))
                throw new ValidationException("Document type cannot be empty.");

            RequestId = _nextId++;
            Applicant = applicant;
            DocumentType = documentType.Trim();
            Priority = priority;
            Status = RequestStatus.Pending;
            SubmittedDate = DateTime.Now;
            AssignedSpecialist = "Unassigned";
        }

        // Abstraction: the Form just calls Approve()/Reject() - it doesn't
        // need to know that approving also updates the applicant's
        // VerificationStatus.
        public void Approve()
        {
            if (Status != RequestStatus.Pending)
                throw new ValidationException("Only pending requests can be approved.");

            Status = RequestStatus.Approved;
            Applicant.VerificationStatus = VerificationStatus.Verified;
        }

        public void Reject(string reason)
        {
            if (Status != RequestStatus.Pending)
                throw new ValidationException("Only pending requests can be rejected.");
            if (string.IsNullOrWhiteSpace(reason))
                throw new ValidationException("A rejection reason is required.");

            Status = RequestStatus.Rejected;
            RejectionReason = reason.Trim();
            Applicant.VerificationStatus = VerificationStatus.Rejected;
        }
    }
}
