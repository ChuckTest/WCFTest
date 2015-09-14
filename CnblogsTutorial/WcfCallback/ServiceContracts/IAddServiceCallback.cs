using System.ServiceModel;

namespace ServiceContracts
{
    public interface IAddServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReturnValue(ReturnData returnData);
    }
}
