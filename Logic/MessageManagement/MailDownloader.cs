namespace MailVerteilerApp;

public class MailDownloader : IMailDownloader
{
    public void DownloadMail()
    {
        Console.WriteLine("Email wurde heruntergeladen");
    }
}