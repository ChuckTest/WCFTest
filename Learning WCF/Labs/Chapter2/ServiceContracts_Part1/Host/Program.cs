using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using BusinessServices;
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
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate Host");
            Console.ReadLine();
            host.Close();

        }
    }
}
