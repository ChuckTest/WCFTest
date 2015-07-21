using System;
using System.Collections.Generic;
using System.Text;
using BusinessServices;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceA));
            host.Open();

            ServiceEndpointCollection endpoints = host.Description.Endpoints;
            foreach (ServiceEndpoint item in endpoints)
            {
                Console.WriteLine(item.Address);
            }

            ServiceHost host2 = new ServiceHost(typeof(ServiceA2));
            host2.Open();

            endpoints = host2.Description.Endpoints;
            foreach (ServiceEndpoint item in endpoints)
            {
                Console.WriteLine(item.Address);
            }

            Console.WriteLine();
            Console.WriteLine("Please press Enter to terminate the Host");
            Console.ReadLine();

            host.Close();
        }
    }
}
