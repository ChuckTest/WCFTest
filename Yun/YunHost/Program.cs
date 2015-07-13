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
            Uri baseAddress = new Uri("http://192.168.1.18:8000/Yun");

            ServiceHost host = new ServiceHost(typeof(Service),baseAddress);

            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                binding.Security.Mode = SecurityMode.None;

                host.AddServiceEndpoint(typeof(IService), binding, "Service");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;

                host.Description.Behaviors.Add(serviceMetadataBehavior);

                host.Open();

                Console.WriteLine("The Service is Ready");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                host.Abort();
            }
            Console.WriteLine("Press Enter to stop the service");
            Console.ReadLine();
            host.Close();
        }
    }
}
