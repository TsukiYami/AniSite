namespace Entities.Entities;

public class AnimeEntity {
    public long nAnimeId { get; private set; }
    public string sAnimeTitle { get; set; }
    public string sAnimeDescription { get; set; }
    public int nNumberEpisodes { get; set; }
    public int nNumerSeasons { get; set; }
    public DateTime dtReleaseDate { get; set; }
    public string sStudio { get; set; }
    public string sAnimator { get; set; }
    public bool IsFinished { get; set; }
    public long nReviewId { get; private set; }
    public long nVA_Id { get; private set; }
}