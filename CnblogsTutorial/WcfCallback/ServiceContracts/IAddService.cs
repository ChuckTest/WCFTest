using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    [ServiceContract(CallbackContract = typeof(IAddServiceCallback))]
    public interface IAddService
    {
        [OperationContract]
        void Login(string userName);
    }
}
