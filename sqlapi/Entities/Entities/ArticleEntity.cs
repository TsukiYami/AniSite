namespace Entities.Entities;

public class ArticleEntity {
    public long nArticleId { get; private set; }
    public string sArticleTitle { get; set; }
    public string sArticleContent { get; set; }
    public string sEvaluate { get; set; }
    public DateTime dtEvaluate { get; private set; } = DateTime.Now;
    public long nUserId { get; private set; }
    public long nCommentId { get; private set; }
}