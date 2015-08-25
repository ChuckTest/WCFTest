using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Client.localhost;

namespace Client
{
    internal class CallbackType : HelloIndigoContractCallback
    {
        public void HelloIndigoCallback(string message)
        {
            Console.WriteLine("Message returned back from server：{0}{2}Callback occurred on thred {1}", message, Thread.CurrentThread.ManagedThreadId, Environment.NewLine);
        }
    }
}
