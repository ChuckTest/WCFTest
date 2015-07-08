using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorWCFService
{
    public class MyCalculatorService : ISimpleCalculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
