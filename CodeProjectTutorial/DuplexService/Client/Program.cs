using System;
using System.ServiceModel;
using Library;

namespace Client
{
    class Program
    {
        static void Main()
        {
            INotificationServices proxy;
            DuplexChannelFactory<INotificationServices> channelFactory;
            const string wsDualHttpBinding = "WSDualHttpBinding_INotificationServices";
            const string netTcpBinding = "NetTcpBinding_INotificationServices";
            InstanceContext context = new InstanceContext(new NotificationServiceCallBack());

            channelFactory = new DuplexChannelFactory<INotificationServices>(context, wsDualHttpBinding);
            proxy = channelFactory.CreateChannel();
            proxy.SendNotification("Are u ready?");

            context = new InstanceContext(new NotificationServiceCallBack());
            channelFactory = new DuplexChannelFactory<INotificationServices>(context, netTcpBinding);
            proxy = channelFactory.CreateChannel();
            proxy.SendNotification("Are u ready?");

            Console.WriteLine("Press Enter to terminate the client");
            Console.ReadLine();
        }
    }
}
