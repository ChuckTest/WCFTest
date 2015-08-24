using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
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
