using System;
using System.ServiceModel;

namespace Library
{
    public class NotificationService : INotificationServices
    {
        public INotificationServiceCallBack Proxy
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<INotificationServiceCallBack>();
            }
        }

        public void SendNotification(string message)
        {
            Console.WriteLine("{1}{2}:{1}Client says {0}", message, Environment.NewLine,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Proxy.OnNotificationSend("Yes");
        }
    }
}
