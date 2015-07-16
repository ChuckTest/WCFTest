using System;
using System.Collections.Generic;
using System.Text;
using BusinessServiceContracts;

namespace BusinessServices
{
    public class ServiceA : IServiceA, IAdmin
    {
        public string Operation1()
        {
            return "IServiceA.Operation1() invoked.";
        }

        public string Operation2()
        {
            return "IServiceA.Operation2() invoked.";
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
