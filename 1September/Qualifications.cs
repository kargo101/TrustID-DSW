using System;
using System.Collections.Generic;
using System.Text;

namespace _1September
{
    public class Qualifications
    { 
        public string Name{ get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string QualificationName { get; set; }
        public string InstitutionName { get; set; }
        public string Year { get; set; }

        public Qualifications(string name, string email, string cellNumber, string qualificationName, string institutionName, string year)
        {
            Name = name;
            Email = email;
            CellNumber = cellNumber;
            QualificationName = qualificationName;
            InstitutionName = institutionName;
            Year = year;
        }

        public string ToFileString()
        {
            return $"{Name},{Email},{CellNumber},{QualificationName},{InstitutionName},{Year}";
        }

    }
}
