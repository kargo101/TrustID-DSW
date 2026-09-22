using System;
using System.Collections.Generic;
using TrustID.Exceptions;

namespace TrustID.Models
{
    public class Review
    {
        private static int _nextId = 1;
        private int _rating;
        private string _comment;

        // Words that should automatically flag a review.
        private static readonly List<string> ProhibitedWords =
            new List<string>
            {
                "fuck",
                "fucking",
                "shit",
                "bitch",
                "bastard",
                "asshole",
                "idiot",
                "stupid",
                "dick",
                "cunt"
            };

        public int ReviewId { get; private set; }
        public User Reviewer { get; private set; }
        public User ReviewedUser { get; private set; }
        public DateTime DateSubmitted { get; private set; }

        public int Rating
        {
            get { return _rating; }
            private set
            {
                if (value < 1 || value > 5)
                    throw new ValidationException(
                        "Rating must be between 1 and 5 stars.");

                _rating = value;
            }
        }

        public string Comment
        {
            get { return _comment; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ValidationException(
                        "Review text cannot be empty.");

                _comment = value.Trim();
            }
        }

        public bool IsFlagged { get; set; }
        public string FlagReason { get; set; } = "";

        public Review(
            User reviewer,
            User reviewedUser,
            int rating,
            string comment)
        {
            if (reviewer == null || reviewedUser == null)
                throw new ValidationException(
                    "Both a reviewer and a reviewed user are required.");

            if (reviewer.UserId == reviewedUser.UserId)
                throw new ValidationException(
                    "You cannot submit a review about yourself.");

            ReviewId = _nextId++;
            Reviewer = reviewer;
            ReviewedUser = reviewedUser;
            Rating = rating;
            Comment = comment;
            DateSubmitted = DateTime.Now;

            IsFlagged = false;
            FlagReason = "";

            // Automatically check the review.
            CheckForInappropriateContent();
        }

        private void CheckForInappropriateContent()
        {
            string lowerComment = Comment.ToLower();

            foreach (string word in ProhibitedWords)
            {
                if (lowerComment.Contains(word))
                {
                    IsFlagged = true;
                    FlagReason = "Inappropriate or offensive language.";
                    return;
                }
            }
        }

        public void Flag(string reason)
        {
            if (string.IsNullOrWhiteSpace(reason))
                throw new ValidationException(
                    "A flag reason is required.");

            IsFlagged = true;
            FlagReason = reason.Trim();
        }

        public void ClearFlag()
        {
            IsFlagged = false;
            FlagReason = "";
        }

        public void RestoreReviewId(int reviewId)
        {
            ReviewId = reviewId;

            if (reviewId >= _nextId)
                _nextId = reviewId + 1;
        }

        public void RestoreDateSubmitted(DateTime date)
        {
            DateSubmitted = date;
        }
    }
}