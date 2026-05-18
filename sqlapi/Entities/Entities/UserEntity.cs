namespace Entities.Entities;

public class UserEntity {
    public long nUserId { get; private set; }
    public string sUsername { get; set; }
    public byte[] anProfilePicture { get; set; }
    public long nLoginId { get; private set; }
}