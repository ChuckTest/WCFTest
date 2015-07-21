using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using YunLib;
using System.ServiceModel.Description;

namespace YunHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service));

            try
            {
                host.Open();

                ServiceEndpointCollection endpoints = host.Description.Endpoints;
                foreach (var item in endpoints)
                {
                    Console.WriteLine(item.Address);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
            }
            Console.WriteLine("Please press Enter to terminate the Host");
            Console.ReadLine();
            host.Close();
        }
    }
}
