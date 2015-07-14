using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ServiceHost host = new ServiceHost(typeof(HelloIndigo.HelloIndigoService), new Uri("http://localhost:8000/HelloIndigo")))
            //{
            //    host.AddServiceEndpoint(typeof(HelloIndigo.IHelloIndigoService), new BasicHttpBinding(), "HelloIndigoService");
            //    host.Open();
            //    Console.WriteLine("Press <ENTER> to terminate the service host");
            //    Console.ReadLine();
            //}
            using (ServiceHost host = new ServiceHost(typeof(HelloIndigoService)))
            {
                host.Open();
                Console.WriteLine("Press <ENTER> to terminate the host application");
                Console.ReadLine();
            }
        }
    }
}
