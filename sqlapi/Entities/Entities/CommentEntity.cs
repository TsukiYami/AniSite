namespace Entities.Entities;

public class CommentEntity {
    public long nCommentId { get; private set; }
    public string sCommentContent { get; set; }
    public DateTime dtComment { get; private set; } = DateTime.Now;
    public long nUserId { get; private set; }
}