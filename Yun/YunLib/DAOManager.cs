using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ZBM.DAO;
using System.Data.SqlClient;

namespace YunLib
{
    class DAOManager
    {
        private DAOManager()
        {
            database = new SqlServerHelper();
            SQLServerConfig config = new SQLServerConfig();
            config.Server = "127.0.0.1";
            config.DatabaseName = "ZBMYunDB1";
            config.UserName = "sa";
            config.Password = "123456";
            config.Port = "1433";
            database.ConfigDatabase(config);
        }

        private static DAOManager instance = new DAOManager();
        internal static DAOManager Instance
        {
            get { return instance; }
        }

        SqlServerHelper database = null;

        internal DataTable SelectProjectByUser(string userName)
        {
            DataTable dataTable = null;
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@UserName",SqlDbType.NVarChar)
                {
                    Value = userName
                }
            };
            dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.SelectProjectByUser, array);
            return dataTable;
        }
    }
}
