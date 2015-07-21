using System;
using System.Collections.Generic;
using System.Text;
using ContentTypes;
using System.ServiceModel;

namespace GigManager
{
    [ServiceContract(Name = "GigManagerServiceContract", Namespace = "http://www.thatindigogirl.com/samples/2006/06", SessionMode = SessionMode.Required)]
    public interface IGigManagerService
    {
        [OperationContract]
        void SaveGig(LinkItem item);

        [OperationContract]
        LinkItem GetGig();
    }
}
