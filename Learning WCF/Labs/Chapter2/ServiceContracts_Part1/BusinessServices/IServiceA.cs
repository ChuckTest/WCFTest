using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServices
{
    [ServiceContract]
    public interface IServiceA
    {
        [OperationContract]
        string Operation1();
        [OperationContract]
        string Operation2();
    }
}
