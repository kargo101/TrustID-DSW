using System;
using System.Collections.Generic;
using System.Text;

namespace _1September
{
   public class User
    {

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }

        public bool EmailNotifications { get; set; } = true;
        public bool PushNotifications { get; set; } = true;
        public bool TransactionAlerts { get; set; } = true;
        public bool Visible { get; set; } = true;

        public User(string name, string secondName, string password, string cellNumber, string email)

        {
            Name = name;
            SecondName = secondName;
            Password = password;
            CellNumber = cellNumber;
            Email = email;
        }
        















    }
}
