namespace MailVerteilerApp;

public interface IMessagePoller
{
    event NewMessageDelegate NewMail;
    void Start();
    void Stop();
}