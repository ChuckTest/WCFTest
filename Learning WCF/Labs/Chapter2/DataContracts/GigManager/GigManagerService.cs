using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using ContentTypes;

namespace GigManager
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class GigManagerService : IGigManagerService
    {
        private LinkItem linkItem;

        public void SaveGig(LinkItem item)
        {
            linkItem = item;
        }

        public LinkItem GetGig()
        {
            return linkItem;
        }
    }
}
