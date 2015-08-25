using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceContracts
{
    public interface IAddServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReturnValue(List<float> list );
    }
}
