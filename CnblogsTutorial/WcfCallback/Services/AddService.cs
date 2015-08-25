using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Timers;
using ServiceContracts;
using ZBM.ZITaker.Log;

namespace Services
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class AddService : IAddService
    {
        private static readonly ConcurrentDictionary<string, IAddServiceCallback> callbacks =
            new ConcurrentDictionary<string, IAddServiceCallback>();

        private static Timer timer;
        private static readonly Random random = new Random();

        public void Login(string userName)
        {
            IAddServiceCallback callback = OperationContext.Current.GetCallbackChannel<IAddServiceCallback>();
            callbacks.AddOrUpdate(userName, callback, (key, value) => value);
            Start();
        }

        public static void Start()
        {
            if (timer == null)
            {
                timer = new Timer {Interval = 1000};
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (KeyValuePair<string, IAddServiceCallback> item in callbacks)
            {
                try
                {
                    int max = random.Next(100, 200);
                    List<float> list = Enumerable.Range(max, 100).Select(x => (float) x).ToList();
                    item.Value.ReturnValue(list);
                }
                catch (Exception ex)
                {
                    IAddServiceCallback callback;
                    callbacks.TryRemove(item.Key, out callback);
                    ExceptionLog.Instance.WriteLog(ex, LogType.BLL);
                }
            }
        }
    }
}
