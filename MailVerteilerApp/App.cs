namespace MailVerteilerApp;

class App
{
    private readonly IMessageDistributor _messageDistributor;

    public App(IMessageDistributor messageDistributor)
    {
        _messageDistributor = messageDistributor;
    }

    public void Run()
    {
        _messageDistributor.Start();
        _messageDistributor.Stop();
    }
}