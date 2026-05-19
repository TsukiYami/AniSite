namespace Entities.DTOs.POST;

public class PostUserDTO {
    public PostUserDTO(string sUsername, byte[] anProfilePicture) {
        this.sUsername = sUsername;
        this.anProfilePicture = anProfilePicture;
    }
    
    public long nUserId { get; private set; }
    public string sUsername { get; set; }
    public byte[] anProfilePicture { get; set; }
    public long nLoginId { get; private set; }
}