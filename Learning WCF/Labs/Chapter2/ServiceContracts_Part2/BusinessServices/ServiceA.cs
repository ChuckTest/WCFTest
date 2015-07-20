using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices
{
    public class ServiceA : IServiceA
    {
        public string Operation1(DateTime datetime)
        {
            return string.Format("IServiceA.Operation1( ) invoked at {0}.", datetime);
        }

        public string Operation2()
        {
            return "IServiceA.Operation2() invoked.";
        }

        public string NewOperation(string s)
        {
            return string.Format("IServiceA.NewOperation( ) invoked with {0}", s);
        }
    }
}
