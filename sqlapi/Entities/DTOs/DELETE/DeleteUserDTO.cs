namespace Entities.DTOs.DELETE;

public class DeleteUserDTO {
    public DeleteUserDTO(long nUserId, string sUsername, byte[] anProfilePicture, long nLoginId) {
        this.nUserId = nUserId;
        this.sUsername = sUsername;
        this.anProfilePicture = anProfilePicture;
        this.nLoginId = nLoginId;
    }
    
    public long nUserId { get; set; }
    public string sUsername { get; set; }
    public byte[] anProfilePicture { get; set; }
    public long nLoginId { get; set; }
}