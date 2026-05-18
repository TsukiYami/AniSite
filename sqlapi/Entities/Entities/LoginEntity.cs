namespace Entities.Entities;

public class LoginEntity {
    public long nLoginId { get; private set; }
    public string sEmail { get; set; }
    public byte[] anPassword { get; set; }
    public DateTime dtAccountCreated { get; private set; } = DateTime.Now;
}