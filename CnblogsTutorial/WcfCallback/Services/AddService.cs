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
            string sessionId = OperationContext.Current.SessionId;
            string message;
            if (sessionId != null)
            {
                callbacks.AddOrUpdate(sessionId, callback, (key, value) => value);
                message = string.Format("客户端会话编号:{0}", sessionId);
            }
            else
            {
                message = "OperationContext.Current.SessionId == null";
            }
            OperationLog.Instance.WriteLog(message, LogType.BLL);
            
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
            DateTime dateTime = DateTime.Now;
            int start = random.Next(200);
            List<float> list = Enumerable.Range(start, 100).Select(x => (float)x).ToList();
            foreach (KeyValuePair<string, IAddServiceCallback> item in callbacks)
            {
                try
                {
                    item.Value.ReturnValue(new ReturnData() {DataList = list, DateTime = dateTime});
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
