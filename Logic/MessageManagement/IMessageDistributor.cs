namespace MailVerteilerApp;

public interface IMessageDistributor
{
    void Start();
    void Stop();
    void Distribute();
}