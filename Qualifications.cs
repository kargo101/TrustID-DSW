using System;

namespace user_dashboard
{
    public class Qualifications
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string QualificationName { get; set; }
        public string InstitutionName { get; set; }
        public string Year { get; set; }

        // Path to the actual uploaded qualification document.
        public string DocumentPath { get; set; }

        // Pending, Approved or Rejected.
        public string Status { get; set; }

        // Only used when an administrator rejects the qualification.
        public string RejectionReason { get; set; }

        public Qualifications(
            string name,
            string email,
            string cellNumber,
            string qualificationName,
            string institutionName,
            string year,
            string documentPath)
        {
            Name = name;
            Email = email;
            CellNumber = cellNumber;
            QualificationName = qualificationName;
            InstitutionName = institutionName;
            Year = year;

            DocumentPath = documentPath;
            Status = "Pending";
            RejectionReason = "";
        }

        public string ToFileString()
        {
            return string.Join(",",
                Name,
                Email,
                CellNumber,
                QualificationName,
                InstitutionName,
                Year,
                DocumentPath,
                Status,
                RejectionReason
            );
        }
    }
}