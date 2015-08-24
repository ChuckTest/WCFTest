using System;
using Client.ServiceReference1;

namespace Client
{
    public class CallbackHandler : ICalculatorDuplexCallback
    {
        public void Equals(double result)
        {
            Console.WriteLine("Time = {1},result = {0}", result,DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff"));
        }

        public void Equation(string eqn)
        {
            Console.WriteLine("Equation({0})", eqn);
        }
    }
}
