using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //EndpointAddress ep = new EndpointAddress("http://localhost:8000/HelloIndigo/HelloIndigoService");
                //IHelloIndigoService proxy = ChannelFactory<IHelloIndigoService>.CreateChannel(new BasicHttpBinding(), ep);
                //string s = proxy.HelloIndigo();

                localhost.HelloIndigoServiceClient proxy = new Client.localhost.HelloIndigoServiceClient();
                string s = proxy.HelloIndigo();
                
                Console.WriteLine(s);
                Console.WriteLine("Press <ENTER> to terminate Client.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
