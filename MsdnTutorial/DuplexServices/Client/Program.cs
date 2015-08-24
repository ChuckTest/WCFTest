using System;
using System.ServiceModel;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Construct InstanceContext to handle messages on callback interface
                InstanceContext instanceContext = new InstanceContext(new CallbackHandler());

                // Create a client
                CalculatorDuplexClient client = new CalculatorDuplexClient(instanceContext);
                client.Open();


                client.AddTo(10);
                //client.SubtractFrom(100);
                //client.DivideBy(10);
                //client.MultiplyBy(3);

                Console.WriteLine("Press Enter to terminate the client");
                Console.ReadKey();
                //client.Close();

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
