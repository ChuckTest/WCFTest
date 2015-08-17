using System.ServiceModel;

namespace HelloIndigo
{
    public interface IHelloIndigoServiceCallback
    {
        [OperationContract]
        void HelloIndigoCallback(string message);
    }
}
