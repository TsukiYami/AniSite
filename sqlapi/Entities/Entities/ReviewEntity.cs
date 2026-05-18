namespace Entities.Entities;

public class ReviewEntity {
    public long nReviewId { get; private set; }
    public short nReview { get; set; }
    public string sReviewContent { get; set; }
    public DateTime dtReview { get; private set; } = DateTime.Now;
    public long nUserId { get; private set; }
}