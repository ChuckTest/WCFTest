using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServiceContracts
{
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    class IServiceA
    {
        [OperationContract]
        string Operation1();
        [OperationContract]
        string Operation2();
    }
}
