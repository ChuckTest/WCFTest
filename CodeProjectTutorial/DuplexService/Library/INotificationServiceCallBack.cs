using System.ServiceModel;

namespace Library
{
    public interface INotificationServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void OnNotificationSend(string message);
    }
}
