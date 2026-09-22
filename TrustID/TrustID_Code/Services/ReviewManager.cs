using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrustID.Exceptions;
using TrustID.Models;
using TrustID.Services;

namespace user_dashboard
{
    public class ReviewManager
    {
        private readonly List<Review> _reviews = new List<Review>();
        private string? _persistenceFilePath;

        public IReadOnlyList<Review> Reviews
        {
            get { return _reviews.AsReadOnly(); }
        }

        public Review SubmitReview(
            User reviewer,
            User reviewedUser,
            int rating,
            string comment)
        {
            bool alreadyReviewed = _reviews.Any(r =>
                r.Reviewer.UserId == reviewer.UserId &&
                r.ReviewedUser.UserId == reviewedUser.UserId);

            if (alreadyReviewed)
            {
                throw new ValidationException(
                    "You have already submitted a review for this user."
                );
            }

            Review review = new Review(
                reviewer,
                reviewedUser,
                rating,
                comment
            );

            _reviews.Add(review);

            if (rating >= 4)
            {
                reviewedUser.TrustScore.PositiveReview();
            }
            else if (rating <= 2)
            {
                reviewedUser.TrustScore.NegativeReview();
            }

            AutoSave();
            Program.SharedUserManager.SaveChanges();

            return review;
        }

        public List<Review> GetReviewsForUser(int userId)
        {
            return _reviews
                .Where(r => r.ReviewedUser.UserId == userId)
                .ToList();
        }

        public List<Review> GetFlaggedReviews()
        {
            return _reviews
                .Where(r => r.IsFlagged)
                .ToList();
        }

        public void FlagReview(int reviewId, string reason)
        {
            Review review = FindReview(reviewId);

            bool wasPositive =
                !review.IsFlagged &&
                review.Rating >= 4;

            bool wasNegative =
                !review.IsFlagged &&
                review.Rating <= 2;

            review.Flag(reason);

            if (wasPositive)
            {
                review.ReviewedUser.TrustScore.RemovePoints(5);
            }
            else if (wasNegative)
            {
                review.ReviewedUser.TrustScore.AddPoints(5);
            }

            AutoSave();
        }

        public void RemoveReview(int reviewId)
        {
            Review review = FindReview(reviewId);

            if (review.Rating >= 4)
            {
                review.ReviewedUser.TrustScore.RemovePoints(5);
            }
            else if (review.Rating <= 2)
            {
                review.ReviewedUser.TrustScore.AddPoints(5);
            }

            _reviews.Remove(review);

            AutoSave();

            Program.SharedUserManager.SaveChanges();
        }
        public void DismissReport(int reviewId)
        {
            Review review = FindReview(reviewId);

            review.ClearFlag();

            AutoSave();

            Program.SharedUserManager.SaveChanges();
        }
        private Review FindReview(int reviewId)
        {
            Review review = _reviews
                .FirstOrDefault(r => r.ReviewId == reviewId);

            if (review == null)
            {
                throw new ValidationException(
                    "Review not found."
                );
            }

            return review;
        }

        public void SetPersistenceFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ValidationException(
                    "Review persistence file path cannot be empty."
                );
            }

            _persistenceFilePath = filePath;
        }

        public void LoadReviews(
            string filePath,
            UserManager userManager)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ValidationException(
                    "Review persistence file path cannot be empty."
                );
            }

            if (userManager == null)
            {
                throw new ValidationException(
                    "User manager is required to load reviews."
                );
            }

            _persistenceFilePath = filePath;

            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('\u001F');

                if (parts.Length != 8)
                    continue;

                int reviewId;
                int reviewerId;
                int reviewedUserId;
                long dateTicks;
                int rating;
                bool isFlagged;

                if (!int.TryParse(parts[0], out reviewId))
                    continue;

                if (!int.TryParse(parts[1], out reviewerId))
                    continue;

                if (!int.TryParse(parts[2], out reviewedUserId))
                    continue;

                if (!long.TryParse(parts[3], out dateTicks))
                    continue;

                if (!int.TryParse(parts[4], out rating))
                    continue;

                if (!bool.TryParse(parts[6], out isFlagged))
                    continue;

                User reviewer;
                User reviewedUser;

                try
                {
                    reviewer = userManager.GetById(reviewerId);
                    reviewedUser = userManager.GetById(reviewedUserId);
                }
                catch (ValidationException)
                {
                    continue;
                }

                try
                {
                    Review review = new Review(
                        reviewer,
                        reviewedUser,
                        rating,
                        parts[5]
                    );

                    review.RestoreReviewId(reviewId);

                    review.RestoreDateSubmitted(
                        new DateTime(dateTicks)
                    );

                    if (isFlagged)
                    {
                        review.Flag(parts[7]);
                    }

                    _reviews.Add(review);

                    // IMPORTANT:
                    // Do NOT AutoSave while loading.
                    // Loading should only read the existing file.
                }
                catch (ValidationException)
                {
                    continue;
                }
            }
        }

        public void SaveReviews(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ValidationException(
                    "Review persistence file path cannot be empty."
                );
            }

            List<string> lines = new List<string>();

            foreach (Review review in _reviews)
            {
                string line = string.Join(
                    "\u001F",
                    new[]
                    {
                        review.ReviewId.ToString(),
                        review.Reviewer.UserId.ToString(),
                        review.ReviewedUser.UserId.ToString(),
                        review.DateSubmitted.Ticks.ToString(),
                        review.Rating.ToString(),
                        review.Comment,
                        review.IsFlagged.ToString(),
                        review.FlagReason ?? ""
                    }
                );

                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        private void AutoSave()
        {
            if (_persistenceFilePath != null)
            {
                SaveReviews(_persistenceFilePath);
            }
        }
        public void SuspendReviewer(int reviewId) 
        { Review review = FindReview(reviewId);
            User reviewer = review.Reviewer; 
            reviewer.AccountStatus = AccountStatus.Suspended; 
            AutoSave(); 
            Program.SharedUserManager.SaveChanges(); 
        }
    }
}