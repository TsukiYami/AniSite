namespace Entities.DTOs.GET;

public class GetArticleDTO {
    public GetArticleDTO(long nArticleId, string sArticleTitle, string sArticleContent, string sEvaluate,  DateTime dtEvaluate,  int nUserId, int nCommentId) {
        this.nArticleId = nArticleId;
        this.sArticleTitle = sArticleTitle;
        this.sArticleContent = sArticleContent;
        this.sEvaluate = sEvaluate;
        this.dtEvaluate = dtEvaluate;
        this.nUserId = nUserId;
        this.nCommentId = nCommentId;
    }
    
    public long nArticleId { get; private set; }
    public string sArticleTitle { get; set; }
    public string sArticleContent { get; set; }
    public string sEvaluate { get; set; }
    public DateTime dtEvaluate { get; private set; }
    public long nUserId { get; private set; }
    public long nCommentId { get; private set; }
}