using System.ServiceModel;

namespace ServiceContracts
{
    [ServiceContract(CallbackContract = typeof(IAddServiceCallback))]
    public interface IAddService
    {
        [OperationContract]
        void Login(string userName);

        void StartProcess(string processFileName);
    }
}
