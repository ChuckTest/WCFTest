using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ZBM.DAO;
using System.Data.SqlClient;
using ZBM.ZITaker.Log;

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

       /// <summary>
        /// 通过用户名，获取指定用户下的项目
       /// </summary>
       /// <param name="userName"></param>
       /// <returns></returns>
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

        /// <summary>
        /// 通过项目名，获取指定项目下的设备
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        internal DataTable SelectDeviceByProject(string projectName)
        {
            DataTable dataTable = null;
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ProjectName",SqlDbType.NVarChar)
                {
                    Value = projectName
                }
            };
            dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.SelectDeviceByProject, array);
            return dataTable;
        }

        /// <summary>
        /// 通过项目名，获取指定项目下的传感器
        /// </summary>
        /// <param name="projectName"></param>
        /// <returns></returns>
        internal DataTable SelectSensorByProject(string projectName)
        {
            DataTable dataTable = null;
            SqlParameter[] array = new SqlParameter[]
            {
                new SqlParameter("@ProjectName",SqlDbType.NVarChar)
                {
                    Value = projectName
                }
            };
            dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.SelectSensorByProject, array);
            return dataTable;
        }

        internal DataTable SelectProject()
        {
            DataTable dataTable = null;
            dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.SelectProject, null);
            return dataTable;
        }

        /// <summary>
        /// 通过项目编号，获取指定项目下的断面
        /// </summary>
        /// <param name="ProjectID"></param>
        /// <returns></returns>
        internal DataTable SelectUnitByProject(string projectName)
        {
            try
            {
                SqlParameter[] array = new SqlParameter[]
                {
                    new SqlParameter("@ProjectName",SqlDbType.NVarChar)
                    {
                        Value = projectName
                    }
                };
                DataTable dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.ProjectUnitSensorSelectProjectUnit, array);
                return dataTable;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        /// <summary>
        /// 通过项目断面编号获取其下的传感器
        /// </summary>
        /// <param name="projectUnitID"></param>
        /// <returns></returns>
        internal DataTable SelectProjectSensorByProjectUnit(int projectUnitID)
        {
            try
            {
                SqlParameter[] array = new SqlParameter[]
                {
                    new SqlParameter("@ProjectUnitID",SqlDbType.Int)
                    {
                        Value = projectUnitID
                    }
                };
                DataTable dataTable = database.ExecuteDataTable(CommandType.Text, SQLStatement.SelectProjectSensorByProjectUnit, array);
                return dataTable;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }
    }
}
