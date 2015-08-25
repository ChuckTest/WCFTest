using System.ServiceModel;
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
