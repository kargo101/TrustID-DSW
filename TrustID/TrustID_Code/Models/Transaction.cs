using System;
using TrustID.Exceptions;

namespace TrustID.Models
{
    public class Transaction
    {
        private static int _nextId = 1;

        public int TransactionId { get; private set; }
        public User FromUser { get; private set; }
        public User ToUser { get; private set; }
        public DateTime Date { get; private set; }
        public TransactionType Type { get; private set; }
        public string Description { get; private set; }
        public TransactionStatus Status { get; set; }

        public Transaction(User fromUser, User toUser, TransactionType type, string description)
        {
            if (fromUser == null || toUser == null)
                throw new ValidationException("Both users involved in the transaction are required.");

            if (fromUser.UserId == toUser.UserId)
                throw new ValidationException("A user cannot transact with themselves.");

            if (string.IsNullOrWhiteSpace(description))
                throw new ValidationException("Transaction description cannot be empty.");

            TransactionId = _nextId++;
            FromUser = fromUser;
            ToUser = toUser;
            Type = type;
            Description = description.Trim();
            Date = DateTime.Now;
            Status = TransactionStatus.Pending;
        }
    }
}
