using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServiceContracts
{
    [ServiceContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IServiceB
    {
        [OperationContract]
        string Operation3();
    }
}
