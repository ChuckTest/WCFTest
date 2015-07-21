using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YunLib
{
    public class Service : IService
    {
        public DataTable SelectProjectByUser(string userName)
        {
            DataTable dataTable = DAOManager.Instance.SelectProjectByUser(userName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }

        public DataTable SelectDeviceByProject(string projectName)
        {
            DataTable dataTable = DAOManager.Instance.SelectDeviceByProject(projectName);
            dataTable.TableName = "DataTable";
            return dataTable;
        }
    }
}
