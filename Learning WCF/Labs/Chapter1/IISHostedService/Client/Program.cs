using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloIndigoServiceClient proxy = new HelloIndigoServiceClient();
            string s = proxy.HelloIndigo();
            Console.WriteLine(s);
            Console.WriteLine("Press <ENTER> to terminate Client.");
            Console.ReadLine();
        }
    }
}
