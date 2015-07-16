using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostA = null;
            ServiceHost hostB = null;
            try
            {
                hostA = new ServiceHost(typeof(BusinessServices.ServiceA));
                hostB = new ServiceHost(typeof(BusinessServices.ServiceB));
                hostA.Open();
                hostB.Open();
                ServiceEndpointCollection listA = hostA.Description.Endpoints;
                foreach (ServiceEndpoint item in listA)
                {
                    Console.WriteLine(item.Address);
                }
                Console.WriteLine();
                listA = hostB.Description.Endpoints;
                foreach (ServiceEndpoint item in listA)
                {
                    Console.WriteLine(item.Address);
                }
                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate Host");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseHost(hostA);
                CloseHost(hostB);
            }
            Console.ReadLine();
        }

        static void CloseHost(ServiceHost host)
        {
            if (host == null)
            {
                throw new ArgumentNullException();
            }
            if (host.State == CommunicationState.Faulted)
            {
                host.Abort();
            }
            else
            {
                host.Close();
            }
        }
    }
}
