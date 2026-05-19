namespace Entities.DTOs.GET;

public class GetUserDTO {
    public GetUserDTO(long nUserId, string sUsername, byte[] anProfilePicture, long nLoginId) {
        this.nUserId = nUserId;
        this.sUsername = sUsername;
        this.anProfilePicture = anProfilePicture;
        this.nLoginId = nLoginId;
    }
    
    public long nUserId { get; private set; }
    public string sUsername { get; private set; }
    public byte[] anProfilePicture { get; private set; }
    public long nLoginId { get; private set; }
}