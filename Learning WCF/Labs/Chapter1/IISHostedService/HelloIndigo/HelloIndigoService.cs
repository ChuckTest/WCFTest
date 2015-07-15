using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace HelloIndigo
{
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }

    public class HelloIndigoService : IHelloIndigoService
    {
        public string HelloIndigo()
        {
            return "Hello Indigo";
        }
    }
}
