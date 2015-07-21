using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices
{
    public class ServiceA2 : IServiceA2
    {
        public string Operation1()
        {
            return "IServiceA2.Operation1() invoked.";
        }

        public string Operation2()
        {
            return "IServiceA2.Operation2() invoked.";
        }

        public string Operation3()
        {
            return "IServiceA2.Operation3() invoked.";
        }
    }
}
