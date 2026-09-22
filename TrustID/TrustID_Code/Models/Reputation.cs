using System;
using System.Collections.Generic;

namespace TrustID.Models
{
    public class Reputation
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int _currentScore;

        private readonly Dictionary<string, int> _contributions =
            new Dictionary<string, int>();

        public int CurrentScore
        {
            get { return _currentScore; }
            private set
            {
                _currentScore = Clamp(value);
            }
        }

        public Reputation()
        {
            _currentScore = 0;
        }

        private static int Clamp(int score)
        {
            if (score < MinScore)
                return MinScore;

            if (score > MaxScore)
                return MaxScore;

            return score;
        }

        // ==========================================
        // GENERAL POINT METHODS
        // ==========================================

        public void AddPoints(int points)
        {
            if (points < 0)
                return;

            CurrentScore += points;
        }

        public void RemovePoints(int points)
        {
            if (points < 0)
                return;

            CurrentScore -= points;
        }

        public void RestoreScore(int score)
        {
            CurrentScore = score;
        }

        // ==========================================
        // CONTRIBUTION TRACKING
        // ==========================================

        private void AddContribution(string factor, int points)
        {
            if (points <= 0)
                return;

            if (!_contributions.ContainsKey(factor))
                _contributions[factor] = 0;

            _contributions[factor] += points;
        }

        private void RemoveContribution(string factor, int points)
        {
            if (points <= 0)
                return;

            if (!_contributions.ContainsKey(factor))
                _contributions[factor] = 0;

            _contributions[factor] -= points;
        }

        public IReadOnlyDictionary<string, int> GetContributions()
        {
            return _contributions;
        }

        public int GetContribution(string factor)
        {
            if (string.IsNullOrWhiteSpace(factor))
                return 0;

            if (_contributions.TryGetValue(factor, out int value))
                return value;

            return 0;
        }

        // Used by UserManager when loading saved Trust Score data.
        public void RestoreContribution(string factor, int points)
        {
            if (string.IsNullOrWhiteSpace(factor))
                return;

            _contributions[factor] = points;
        }

        // ==========================================
        // TRANSACTIONS
        // ==========================================

        public void TransactionCompleted()
        {
            AddPoints(15);
            AddContribution("Completed Transactions", 15);
        }

        // ==========================================
        // VERIFICATION
        // ==========================================

        public void VerificationSubmitted()
        {
            AddPoints(5);
            AddContribution("Verification Submitted", 5);
        }

        public void VerificationApproved()
        {
            AddPoints(20);
            AddContribution("Verification Approved", 20);
        }

        public void VerificationRejected()
        {
            RemovePoints(10);
            RemoveContribution("Verification Rejected", 10);
        }

        // ==========================================
        // QUALIFICATIONS
        // ==========================================

        public void QualificationApproved()
        {
            AddPoints(10);
            AddContribution("Qualifications Approved", 10);
        }

        public void QualificationRejected()
        {
            RemovePoints(5);
            RemoveContribution("Qualifications Rejected", 5);
        }

        // ==========================================
        // REVIEWS
        // ==========================================

        public void PositiveReview()
        {
            AddPoints(5);
            AddContribution("Positive Reviews", 5);
        }

        public void NegativeReview()
        {
            RemovePoints(5);
            AddContribution("Negative Reviews", -5);
        }

        // ==========================================
        // TRUST TIER
        // ==========================================

        public string GetTier()
        {
            if (CurrentScore >= 100)
                return "Trusted";

            if (CurrentScore >= 85)
                return "Highly Trusted";

            if (CurrentScore >= 70)
                return "Trusted";

            if (CurrentScore >= 50)
                return "Fair";

            if (CurrentScore >= 30)
                return "Low Trust";

            return "Critical";
        }
    }
}