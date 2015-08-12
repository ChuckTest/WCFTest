using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace DuplexServiceContract
{
    public interface ICalculatorDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void Equals(double result);

        [OperationContract(IsOneWay = true)]
        void Equation(string eqn);
    }
}
