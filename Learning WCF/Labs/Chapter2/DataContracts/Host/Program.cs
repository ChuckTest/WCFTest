using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using GigManager;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(GigManagerService));
            host.Open();

            ServiceEndpointCollection endpoints = host.Description.Endpoints;
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
