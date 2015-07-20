﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace BusinessServices
{
    [ServiceContract(Name = "ServiceAContract",Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public interface IServiceA
    {
        [OperationContract]
        string Operation1(DateTime datetime);

        //[OperationContract]
        //string Operation2();

        [OperationContract]
        string NewOperation([MessageParameter(Name = "string")]string s);
    }
}
