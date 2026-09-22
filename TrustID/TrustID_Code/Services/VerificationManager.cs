using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrustID.Exceptions;
using TrustID.Models;

namespace TrustID.Services
{
    public class VerificationManager
    {
        private readonly List<VerificationRequest> _requests =
            new List<VerificationRequest>();

        private string _persistenceFile = "";

        public IReadOnlyList<VerificationRequest> Requests
        {
            get { return _requests.AsReadOnly(); }
        }

        // Sets the file used to save verification requests.
        public void SetPersistenceFile(string filePath)
        {
            _persistenceFile = filePath;
        }

        // SUBMIT
        public VerificationRequest SubmitRequest(
            User applicant,
            string documentType,
            string documentPath,
            RequestPriority priority)
        {
            if (applicant == null)
                throw new ValidationException(
                    "A verification request must belong to a user.");

            bool alreadyPending = _requests.Any(r =>
                r.Applicant.UserId == applicant.UserId &&
                r.Status == RequestStatus.Pending);

            if (alreadyPending)
                throw new ValidationException(
                    "This user already has a pending verification request.");

            var request = new VerificationRequest(
                applicant,
                documentType,
                documentPath,
                priority);

            _requests.Add(request);

            // Award points for submitting a verification.
            applicant.TrustScore.VerificationSubmitted();

            SaveRequests();

            return request;
        }

        // GET PENDING REQUESTS
        public List<VerificationRequest> GetPendingRequests()
        {
            return _requests
                .Where(r => r.Status == RequestStatus.Pending)
                .ToList();
        }

        // APPROVE
        public void ApproveRequest(int requestId)
        {
            VerificationRequest request = FindRequest(requestId);

            request.Approve();

            SaveRequests();
        }

        // REJECT
        public void RejectRequest(int requestId, string reason)
        {
            VerificationRequest request = FindRequest(requestId);

            request.Reject(reason);

            SaveRequests();
        }

        // SAVE
        public void SaveRequests()
        {
            if (string.IsNullOrWhiteSpace(_persistenceFile))
                return;

            try
            {
                List<string> lines = new List<string>();

                foreach (VerificationRequest request in _requests)
                {
                    string line = string.Join(
                        "\u001F",
                        request.RequestId,
                        request.Applicant.UserId,
                        request.DocumentType,
                        request.DocumentPath,
                        request.Priority,
                        request.AssignedSpecialist,
                        request.Status,
                        request.SubmittedDate.Ticks,
                        request.RejectionReason ?? "");

                    lines.Add(line);
                }

                File.WriteAllLines(_persistenceFile, lines);
            }
            catch (Exception ex)
            {
                throw new ValidationException(
                    "Unable to save verification requests: " +
                    ex.Message);
            }
        }

        // LOAD
        public void LoadRequests(
            string filePath,
            UserManager userManager)
        {
            _persistenceFile = filePath;

            _requests.Clear();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('\u001F');

                if (parts.Length < 9)
                    continue;

                try
                {
                    int requestId = int.Parse(parts[0]);
                    int applicantId = int.Parse(parts[1]);

                    User applicant =
                        userManager.GetById(applicantId);

                    if (applicant == null)
                        continue;

                    string documentType = parts[2];
                    string documentPath = parts[3];

                    RequestPriority priority =
                        (RequestPriority)Enum.Parse(
                            typeof(RequestPriority),
                            parts[4]);

                    string assignedSpecialist = parts[5];

                    RequestStatus status =
                        (RequestStatus)Enum.Parse(
                            typeof(RequestStatus),
                            parts[6]);

                    DateTime submittedDate =
                        new DateTime(long.Parse(parts[7]));

                    string rejectionReason = parts[8];

                    VerificationRequest request =
                        new VerificationRequest(
                            applicant,
                            documentType,
                            documentPath,
                            priority);

                    request.RestoreRequestId(requestId);
                    request.RestoreAssignedSpecialist(
                        assignedSpecialist);
                    request.RestoreStatus(
                        status);
                    request.RestoreSubmittedDate(
                        submittedDate);
                    request.RestoreRejectionReason(
                        rejectionReason);

                    _requests.Add(request);
                }
                catch
                {
                    // Ignore invalid records so one damaged
                    // record does not prevent the application
                    // from loading.
                }
            }
        }

        // FIND REQUEST
        private VerificationRequest FindRequest(int requestId)
        {
            VerificationRequest request =
                _requests.FirstOrDefault(
                    r => r.RequestId == requestId);

            if (request == null)
                throw new ValidationException(
                    "Verification request not found.");

            return request;
        }
    }
}