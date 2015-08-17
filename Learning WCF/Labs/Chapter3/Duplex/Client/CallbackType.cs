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
            Console.WriteLine("HelloIndigoCallback on thread {0}",Thread.CurrentThread.GetHashCode());
        }
    }
}
