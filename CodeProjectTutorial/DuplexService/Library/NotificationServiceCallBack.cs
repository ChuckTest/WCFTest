using System;
using System.ServiceModel;

namespace Library
{
    /// <summary>
    /// Here CallbackBehavior refers to how the callback of this operation will act which is similar to ServiceBehavior.
    /// </summary>
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class NotificationServiceCallBack : INotificationServiceCallBack
    {
        public void OnNotificationSend(string message)
        {
            Console.WriteLine("{0}:{2}{1}{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), message,Environment.NewLine);
            Console.ReadLine();
        }
    }
}
