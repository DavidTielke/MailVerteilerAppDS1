using System.Data;
using Data.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace MailVerteilerApp
{
    // ## Namensmuster ##
    // Distributor
    // Poller
    // Sender
    // Repository
    // Manager

    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();

            collection.AddTransient<IMailDownloader, MailDownloader>();
            collection.AddTransient<IMessagePoller, Pop3Poller>();
            collection.AddTransient<IMessageSender, SmtpSender>();
            collection.AddTransient<IMessageDistributor, MessageDistributor>();
            collection.AddTransient<IReceiverRepository, ReceiverRepository>();
            collection.AddTransient<IReceiverManager, ReceiverManager>();
            collection.AddSingleton<IConfigurator, Configurator>();
            collection.AddTransient<App>();

            var kernel = collection.BuildServiceProvider();

            var config = kernel.GetService<IConfigurator>();
            config.Set("SmtpUsername", "David");
            config.Set("SmtpPassword", "geheim");

            var app = kernel.GetService<App>();
            app.Run();
        }
    }
}
