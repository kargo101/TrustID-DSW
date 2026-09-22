using System;

namespace user_dashboard
{
    public class Transactions
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }

        private string transactionID;
        private string transactionType;
        private DateTime dateOfExecution;
        private string description;
        private string counterPartySearch;
        private decimal userAmount;

        public Transactions(string name, string email, string cell, string counterParty, decimal amount, string desc, DateTime date, string type, string transID)
        {
            Name = name;
            Email = email;
            CellNumber = cell;
            transactionID = transID;
            transactionType = type;
            dateOfExecution = date;
            description = desc;
            counterPartySearch = counterParty;
            userAmount = amount;
        }

        public string ToFileString()
        {
            return $"{Name}|{Email}|{CellNumber}|{transactionID}|{transactionType}|{dateOfExecution:yyyy/MM/dd}|{userAmount}|{counterPartySearch}|{description}";
        }

        public string GetTransactionID() => transactionID;
        public string GetTransactionType() => transactionType;
        public DateTime GetDateOfExecution() => dateOfExecution;
        public string GetDescription() => description;
        public string GetCounterParty() => counterPartySearch;
        public decimal GetAmount() => userAmount;
    }
}