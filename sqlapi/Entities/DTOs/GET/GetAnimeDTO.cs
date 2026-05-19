namespace Entities.DTOs.GET;

public class GetAnimeDTO {
    
    public GetAnimeDTO(long nAnimeId, string sAnimeTitle, string sAnimeDescription, int nNumberEpisodes, int nNumerSeasons,
        DateTime dtReleaseDate, string sStudio, string sAnimator, bool bIsFinished,  long nReviewId, long nVA_Id) {
        this.nAnimeId = nAnimeId;
        this.sAnimeTitle = sAnimeTitle;
        this.sAnimeDescription = sAnimeDescription;
        this.nNumberEpisodes = nNumberEpisodes;
        this.nNumerSeasons = nNumerSeasons;
        this.dtReleaseDate = dtReleaseDate;
        this.sStudio = sStudio;
        this.sAnimator = sAnimator;
        this.bIsFinished = bIsFinished;
        this.nReviewId = nReviewId;
        this.nVA_Id = nVA_Id;
    }
    
    public long nAnimeId { get; private set; }
    public string sAnimeTitle { get; set; }
    public string sAnimeDescription { get; set; }
    public int nNumberEpisodes { get; set; }
    public int nNumerSeasons { get; set; }
    public DateTime dtReleaseDate { get; set; }
    public string sStudio { get; set; }
    public string sAnimator { get; set; }
    public bool bIsFinished { get; set; }
    public long nReviewId { get; private set; }
    public long nVA_Id { get; private set; }
}