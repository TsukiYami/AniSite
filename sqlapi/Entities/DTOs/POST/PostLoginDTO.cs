namespace Entities.DTOs.POST;

public class PostLoginDTO {
    public PostLoginDTO(string sEmail, byte[] anPassword) {
        this.sEmail = sEmail;
        this.anPassword = anPassword;
    }
    
    public long nLoginId { get; private set; }
    public string sEmail { get; set; }
    public byte[] anPassword { get; set; }
    public DateTime dtAccountCreated { get; private set; } = DateTime.Now;
}