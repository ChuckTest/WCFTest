using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServices
{
    interface IServiceA2 : IServiceA
    {
        [OperationContract]
        string Operation3();
    }
}
