// ?2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.ServiceModel;
using System.Threading;
using Client.localhost;

namespace Client
{
    class Program
    {
        private static void Main()
        {
            try
            {
                Console.WriteLine("HelloIndigoCallback on thread {0}", Thread.CurrentThread.GetHashCode());
                Console.WriteLine();

                CallbackType callbackType = new CallbackType();
                InstanceContext instanceContext = new InstanceContext(callbackType);

                HelloIndigoContractClient client = new HelloIndigoContractClient(instanceContext);

                Console.WriteLine("Calling HelloIndigo()");
                client.HelloIndigo("Hello from Client.");
                Console.WriteLine("Returned from HelloIndigo()");
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
            }
            Console.ReadLine();
        }

    }
}
