using System.ServiceModel;

namespace Library
{
    [ServiceContract(CallbackContract = typeof(INotificationServiceCallBack))]
    public interface INotificationServices
    {
        [OperationContract]
        void SendNotification(string message);
    }
}
