using System;
using System.Collections.Generic;
using System.Text;

namespace _1September
{
    public class VerificationRequest
    {
        public string RequestId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string FullName => $"{Name} {SecondName}";
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string Qualification {  get; set; }
        public string IdDocumentPath { get; set; }
        public string QualificationDocumentPath { get; set; }
        public string Status { get; set; } // Pending, Approved, Rejected
        public System.DateTime Date { get; set; }

        public string ToFileString()
        {
            return $"{RequestId}|{Name}|{SecondName}|{CellNumber}|{Email}|{Qualification}|{IdDocumentPath}|{QualificationDocumentPath}|{Status}|{Date}";
        }

        public static VerificationRequest FromFileString(string fileString)
        {
            var parts = fileString.Split('|');
            if (parts.Length != 10)
                throw new FormatException("Invalid verification request format.");
            return new VerificationRequest
            {
                RequestId = parts[0],
                Name = parts[1],
                SecondName = parts[2],
                Email = parts[3],
                CellNumber = parts[4],
                Qualification = parts[5],
                IdDocumentPath = parts[6],
                QualificationDocumentPath = parts[7],
                Status = parts[8],
                Date =System.DateTime.Parse(parts[9])
            };
        }

    }
}
