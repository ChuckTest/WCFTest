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

        //根据断面来获取断面下的传感器
        //首先获取项目
        //确定项目之后，获取项目下的所有断面，然后选择一个断面
        //有了项目断面之后，就可以获取此断面下的传感器(这里的传感器是和项目关联的表里面的编号)
        [OperationContract]
        DataTable SelectProject();

        [OperationContract]
        DataTable SelectUnitByProject(string projectName);

        [OperationContract]
        DataTable SelectProjectSensorByProjectUnit(int projectUnitID);

        //根据项目设备号获取项目设备通道和项目传感器的关联
        [OperationContract]
        DataTable SelectChannelSensorByProjectDevice(int projectDeviceID);

        [OperationContract]
        DataTable SelectUser();

        [OperationContract]
        DataTable SelectDevice();
    }
}
