using System;

namespace TrustID.Models
{
    public enum UserType
    {
        Individual,
        Business,
        Administrator
    }

    public enum VerificationStatus
    {
        Unverified,
        Pending,
        Verified,
        Rejected
    }

    public enum AccountStatus
    {
        Active,
        Pending,
        Suspended
    }

    public enum TransactionStatus
    {
        Pending,
        Completed,
        Failed,
        Disputed
    }

    public enum TransactionType
    {
        Purchase,
        Service,
        Transfer,
        Other
    }

    public enum RequestPriority
    {
        Low,
        Medium,
        High
    }

    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }

    public enum QualificationStatus
    {
        Unverified,
        Verified,
        Rejected
    }
}
