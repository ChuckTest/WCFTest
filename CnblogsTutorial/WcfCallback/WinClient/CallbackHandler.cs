using System.Collections.Generic;
using System.ServiceModel;
using ServiceContracts;

namespace WinClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public class CallbackHandler : IAddServiceCallback
    {
        public void ReturnValue(ReturnData returnData)
        {
            EventManager.Instance.OnDataArrived(new DataArrivedEventArgs() {ReturnData = returnData});
        }
    }
}
