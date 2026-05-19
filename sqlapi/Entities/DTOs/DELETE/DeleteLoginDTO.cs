namespace Entities.DTOs.DELETE;

public class DeleteLoginDTO {
    public DeleteLoginDTO(long nLoginId, string sEmail, byte[] anPassword, DateTime dtAccountCreated) {
        this.nLoginId = nLoginId;
        this.sEmail = sEmail;
        this.anPassword = anPassword;
        this.dtAccountCreated = dtAccountCreated;
    }
    
    public long nLoginId { get; set; }
    public string sEmail { get; set; }
    public byte[] anPassword { get; set; }
    public DateTime dtAccountCreated { get; set; }
}