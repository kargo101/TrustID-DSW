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
        public string DocumentPath { get; private set; }
        public RequestPriority Priority { get; set; }
        public string AssignedSpecialist { get; set; }
        public RequestStatus Status { get; private set; }
        public DateTime SubmittedDate { get; private set; }
        public string RejectionReason { get; private set; }

        public VerificationRequest(
            User applicant,
            string documentType,
            string documentPath,
            RequestPriority priority)
        {
            if (applicant == null)
                throw new ValidationException(
                    "A verification request must belong to a user.");

            if (string.IsNullOrWhiteSpace(documentType))
                throw new ValidationException(
                    "Document type cannot be empty.");

            if (string.IsNullOrWhiteSpace(documentPath))
                throw new ValidationException(
                    "A document must be uploaded.");

            RequestId = _nextId++;

            Applicant = applicant;
            DocumentType = documentType.Trim();
            DocumentPath = documentPath.Trim();
            Priority = priority;

            Status = RequestStatus.Pending;
            SubmittedDate = DateTime.Now;
            AssignedSpecialist = "Unassigned";
            RejectionReason = "";
        }

        // APPROVE
        public void Approve()
        {
            if (Status != RequestStatus.Pending)
                throw new ValidationException(
                    "Only pending requests can be approved.");

            Status = RequestStatus.Approved;

            Applicant.VerificationStatus =
                VerificationStatus.Verified;

            Applicant.TrustScore.VerificationApproved();
        }

        // REJECT
        public void Reject(string reason)
        {
            if (Status != RequestStatus.Pending)
                throw new ValidationException(
                    "Only pending requests can be rejected.");

            if (string.IsNullOrWhiteSpace(reason))
                throw new ValidationException(
                    "A rejection reason is required.");

            Status = RequestStatus.Rejected;

            RejectionReason = reason.Trim();

            Applicant.VerificationStatus =
                VerificationStatus.Rejected;

            Applicant.TrustScore.VerificationRejected();
        }

        // RESTORE METHODS
        // These are used when loading saved requests from the file.

        public void RestoreRequestId(int requestId)
        {
            RequestId = requestId;

            if (requestId >= _nextId)
                _nextId = requestId + 1;
        }

        public void RestoreAssignedSpecialist(
            string assignedSpecialist)
        {
            AssignedSpecialist =
                string.IsNullOrWhiteSpace(assignedSpecialist)
                    ? "Unassigned"
                    : assignedSpecialist;
        }

        public void RestoreStatus(RequestStatus status)
        {
            Status = status;
        }

        public void RestoreSubmittedDate(DateTime date)
        {
            SubmittedDate = date;
        }

        public void RestoreRejectionReason(
            string rejectionReason)
        {
            RejectionReason =
                rejectionReason ?? "";
        }
    }
}