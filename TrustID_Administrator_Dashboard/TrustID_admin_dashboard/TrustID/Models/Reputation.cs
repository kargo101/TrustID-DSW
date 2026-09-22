using System;
using System.Collections.Generic;
using System.Linq;
using TrustID.Exceptions;

namespace TrustID.Models
{
    // Encapsulates trust score calculation for a single user.
    // Keeps the maths out of the User class and out of the Forms.
    public class Reputation
    {
        private const int MinScore = 0;
        private const int MaxScore = 1000;

        private int _currentScore;

        public int CurrentScore
        {
            get { return _currentScore; }
            private set { _currentScore = Clamp(value); }
        }

        public Reputation()
        {
            _currentScore = 500; // neutral starting score
        }

        private static int Clamp(int score)
        {
            if (score < MinScore) return MinScore;
            if (score > MaxScore) return MaxScore;
            return score;
        }

        // Recalculates the score from every non-flagged review a user has
        // received. Simple weighted model: base 500 + average deviation
        // from a neutral 3-star rating, scaled up.
        public int CalculateTrustScore(List<Review> receivedReviews)
        {
            if (receivedReviews == null)
                throw new ValidationException("Review list cannot be null when calculating a Trust Score.");

            var validReviews = receivedReviews.Where(r => !r.IsFlagged).ToList();

            if (validReviews.Count == 0)
            {
                CurrentScore = 500;
                return CurrentScore;
            }

            double averageRating = validReviews.Average(r => r.Rating);

            // Map 1-5 star average onto a 0-1000 score band.
            double scaled = ((averageRating - 1) / 4.0) * 1000;

            // Volume bonus: users with more validated reviews get a small
            // confidence boost, capped so it can't dominate the score.
            int volumeBonus = Math.Min(validReviews.Count * 2, 50);

            CurrentScore = (int)Math.Round(scaled) + volumeBonus;
            return CurrentScore;
        }

        public string GetTier()
        {
            if (_currentScore >= 850) return "Excellent";
            if (_currentScore >= 700) return "Good";
            if (_currentScore >= 500) return "Fair";
            if (_currentScore >= 300) return "Poor";
            return "Critical";
        }
    }
}
