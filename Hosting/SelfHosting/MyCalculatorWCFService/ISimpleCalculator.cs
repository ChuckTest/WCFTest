using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyCalculatorWCFService
{
    [ServiceContract]
    public interface ISimpleCalculator
    {
        [OperationContract]
        int Sum(int number1, int number2);
    }
}
