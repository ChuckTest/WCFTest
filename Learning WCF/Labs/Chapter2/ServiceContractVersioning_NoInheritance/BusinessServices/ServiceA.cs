using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices
{
    public class ServiceA : IServiceA
    {
        public string Operation1()
        {
            return "IServiceA.Operation1() invoked.";
        }

        public string Operation2()
        {
            return "IServiceA.Operation2() invoked.";
        }
    }
}
