using System.Collections.Generic;
using System.Linq;
using TrustID.Exceptions;
using TrustID.Models;

namespace TrustID.Services
{
    public class ReviewManager
    {
        private readonly List<Review> _reviews = new List<Review>();

        public IReadOnlyList<Review> Reviews
        {
            get { return _reviews.AsReadOnly(); }
        }

        // Abstraction: the Form calls SubmitReview() with raw values and
        // never has to know a review triggers a trust score recalculation.
        public Review SubmitReview(User reviewer, User reviewedUser, int rating, string comment)
        {
            // Duplicate reviews: same reviewer -> same user, not flagged/removed
            bool alreadyReviewed = _reviews.Any(r =>
                r.Reviewer.UserId == reviewer.UserId &&
                r.ReviewedUser.UserId == reviewedUser.UserId);

            if (alreadyReviewed)
                throw new ValidationException("You have already submitted a review for this user.");

            var review = new Review(reviewer, reviewedUser, rating, comment);
            _reviews.Add(review);

            RecalculateTrustScore(reviewedUser);
            return review;
        }

        public List<Review> GetReviewsForUser(int userId)
        {
            return _reviews.Where(r => r.ReviewedUser.UserId == userId).ToList();
        }

        public List<Review> GetFlaggedReviews()
        {
            return _reviews.Where(r => r.IsFlagged).ToList();
        }

        public void FlagReview(int reviewId, string reason)
        {
            Review review = FindReview(reviewId);
            review.Flag(reason);
            RecalculateTrustScore(review.ReviewedUser);
        }

        public void RemoveReview(int reviewId)
        {
            Review review = FindReview(reviewId);
            _reviews.Remove(review);
            RecalculateTrustScore(review.ReviewedUser);
        }

        public void DismissReport(int reviewId)
        {
            Review review = FindReview(reviewId);
            review.ClearFlag();
            RecalculateTrustScore(review.ReviewedUser);
        }

        private void RecalculateTrustScore(User user)
        {
            List<Review> receivedReviews = GetReviewsForUser(user.UserId);
            user.TrustScore.CalculateTrustScore(receivedReviews);
        }

        private Review FindReview(int reviewId)
        {
            Review review = _reviews.FirstOrDefault(r => r.ReviewId == reviewId);
            if (review == null)
                throw new ValidationException("Review not found.");
            return review;
        }
    }
}
