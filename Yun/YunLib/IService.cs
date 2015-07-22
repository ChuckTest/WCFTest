using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;

namespace YunLib
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        DataTable SelectProjectByUser(string userName);

        [OperationContract]
        DataTable SelectDeviceByProject(string projectName);

        [OperationContract]
        DataTable SelectSensorByProject(string projectName);
    }
}
