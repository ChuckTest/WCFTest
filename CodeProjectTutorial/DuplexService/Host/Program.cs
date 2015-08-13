using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Library;

namespace Host
{
    class Program
    {
        static void Main()
        {
            ServiceHost serviceHost = new ServiceHost(typeof (NotificationService));
            serviceHost.Open();
            ServiceEndpointCollection collection = serviceHost.Description.Endpoints;
            foreach (ServiceEndpoint endpoint in collection)
            {
                Console.WriteLine(endpoint.Address);
            }
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
