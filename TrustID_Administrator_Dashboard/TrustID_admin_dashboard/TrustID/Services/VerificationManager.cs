using System.Collections.Generic;
using System.Linq;
using TrustID.Exceptions;
using TrustID.Models;

namespace TrustID.Services
{
    public class VerificationManager
    {
        private readonly List<VerificationRequest> _requests = new List<VerificationRequest>();

        public IReadOnlyList<VerificationRequest> Requests
        {
            get { return _requests.AsReadOnly(); }
        }

        public VerificationRequest SubmitRequest(User applicant, string documentType, RequestPriority priority)
        {
            // Duplicate verification requests
            bool alreadyPending = _requests.Any(r =>
                r.Applicant.UserId == applicant.UserId && r.Status == RequestStatus.Pending);

            if (alreadyPending)
                throw new ValidationException("This user already has a pending verification request.");

            var request = new VerificationRequest(applicant, documentType, priority);
            _requests.Add(request);
            return request;
        }

        public List<VerificationRequest> GetPendingRequests()
        {
            return _requests.Where(r => r.Status == RequestStatus.Pending).ToList();
        }

        // Forms only ever call ApproveRequest()/RejectRequest() - the
        // "how" (updating the applicant's VerificationStatus) is hidden
        // inside VerificationRequest.Approve()/Reject().
        public void ApproveRequest(int requestId)
        {
            VerificationRequest request = FindRequest(requestId);
            request.Approve();
        }

        public void RejectRequest(int requestId, string reason)
        {
            VerificationRequest request = FindRequest(requestId);
            request.Reject(reason);
        }

        private VerificationRequest FindRequest(int requestId)
        {
            VerificationRequest request = _requests.FirstOrDefault(r => r.RequestId == requestId);
            if (request == null)
                throw new ValidationException("Verification request not found.");
            return request;
        }
    }
}
