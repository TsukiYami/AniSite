namespace Entities.DTOs.DELETE;

public class DeleteLoginDTO {
    public DeleteLoginDTO(long nLoginId, string sEmail, byte[] anPassword, DateTime dtAccountCreated) {}
    
    public long nLoginId { get; private set; }
    public string sEmail { get; set; }
    public byte[] anPassword { get; set; }
    public DateTime dtAccountCreated { get; private set; }
}