// ?2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System.ServiceModel;

namespace HelloIndigo
{

    [ServiceContract(Name = "HelloIndigoContract", Namespace = "http://www.thatindigogirl.com/samples/2006/06",CallbackContract = typeof(IHelloIndigoServiceCallback))]
    public interface IHelloIndigoService
    {
        [OperationContract]
        void HelloIndigo(string message);
    }

    /// <summary>
    /// ConcurrencyMode…Ë÷√Œ™Reentrant
    /// ∑Ò‘ÚYou°Øll receive an InvalidOperationException at the service stating that the operation will deadlock.
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class HelloIndigoService : IHelloIndigoService
    {
        #region IHelloIndigoService Members

        public void HelloIndigo(string message)
        {
            IHelloIndigoServiceCallback callback =
                OperationContext.Current.GetCallbackChannel<IHelloIndigoServiceCallback>();
            callback.HelloIndigoCallback(message);
        }
          
        #endregion
    }

}

