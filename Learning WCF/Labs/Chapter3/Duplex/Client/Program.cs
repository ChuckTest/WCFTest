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

                CallbackType callbackType = new CallbackType();
                InstanceContext instanceContext = new InstanceContext(callbackType);

                HelloIndigoContractClient client = new HelloIndigoContractClient(instanceContext);

                const string message = "Hello world!";
                Console.WriteLine("Send message \"{0}\" to server.", message);
                Console.WriteLine("Client started on thread {0}", Thread.CurrentThread.GetHashCode());
                Console.WriteLine();

                client.HelloIndigo(message);

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
