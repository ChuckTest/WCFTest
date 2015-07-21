using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServices
{
    [ServiceContract(Name = "ServiceAContract", Namespace = "http://www.thatindigogirl.com/samples/2006/08")]
    public interface IServiceA2
    {
        [OperationContract]
        string Operation1();

        [OperationContract]
        string Operation2();

        [OperationContract]
        string Operation3();
    }
}
