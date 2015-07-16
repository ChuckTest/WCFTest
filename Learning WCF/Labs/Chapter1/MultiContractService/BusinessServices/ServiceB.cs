using System;
using System.Collections.Generic;
using System.Text;
using BusinessServiceContracts;

namespace BusinessServices
{
    public class ServiceB : IServiceB, IAdmin
    {
        public string Operation3()
        {
            return "IServiceB.Operation3() invoked.";
        }

        public string AdminOperation1()
        {
            return "IAdmin.AdminOperation1 invoked.";
        }

        public string AdminOperation2()
        {
            return "IAdmin.AdminOperation2 invoked.";
        }
    }
}
