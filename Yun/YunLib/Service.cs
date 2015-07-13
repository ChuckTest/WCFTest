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
    }
}
