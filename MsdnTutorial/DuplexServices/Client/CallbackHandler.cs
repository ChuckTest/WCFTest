using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.ServiceReference1;

namespace Client
{
    public class CallbackHandler : ICalculatorDuplexCallback
    {
        public void Equals(double result)
        {
            Console.WriteLine("Equals({0})", result);
        }

        public void Equation(string eqn)
        {
            Console.WriteLine("Equation({0})", eqn);
        }
    }
}
