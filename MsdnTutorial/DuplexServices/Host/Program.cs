using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using DuplexService;

namespace Host
{
    class Program
    {
        static void Main()
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(CalculatorService));
                host.Open();
                ServiceEndpointCollection collection = host.Description.Endpoints;
                foreach (ServiceEndpoint endpoint in collection)
                {
                    Console.WriteLine(endpoint.Address);
                }
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
