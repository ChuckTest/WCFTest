using System.Collections.Generic;
using System.ServiceModel;
using ServiceContracts;

namespace WinClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public class CallbackHandler : IAddServiceCallback
    {
        public void ReturnValue(List<float> list )
        {
            EventManager.Instance.OnDataArrived(new DataArrivedEventArgs(){List = list});
        }
    }
}
