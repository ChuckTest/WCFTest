using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using ServiceContracts;

namespace WinClient
{
    public class AddServiceClient : DuplexClientBase<IAddService>, IAddService
    {
        public AddServiceClient(InstanceContext instanceContext)
            : base(instanceContext)
        {
        }

        public void Login(string userName)
        {
             Channel.Login(userName);
        }
    }
}
