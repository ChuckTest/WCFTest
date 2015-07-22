using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YunClient.localhost;
using ZBM.Utility;
using ZBM.ZITaker.Log;

namespace YunClient
{
    public partial class FormProjectUnitSensor : Form
    {
        private DataTable dataTableProject;
        private DataRow dataRowProject;

        private DataTable dataTableProjectUnit;
        private DataRow dataRowProjectUnit;

        private DataTable dataTableProjectSensor;
        private DataRow dataRowProjectSensor;

        public FormProjectUnitSensor()
        {
            InitializeComponent();
            try
            {
                DataGridViewSetting();
                LoadProject();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        /// <summary>
        /// 加载项目列表
        /// </summary>
        private void LoadProject()
        {
            try
            {
                ServiceClient client = new ServiceClient();
                dataTableProject = client.SelectProject();
                dataGridViewProject.DataSource = dataTableProject;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void DataGridViewSetting()
        {
            ZBMDataGridView.Config(dataGridViewProject);
            ZBMDataGridView.Config(dataGridViewProjectUnit);
            ZBMDataGridView.Config(dataGridViewProjectSensor);
        }

        private void dataGridViewProject_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    if (dataGridViewProject.Rows.Count > 0)
                    {
                        dataRowProject = dataTableProject.Rows[e.Row.Index];
                        //根据项目编号来获取断面以及传感器的信息
                        string projectName = Convert.ToString(dataRowProject["ProjectName"]);
                        ServiceClient client = new ServiceClient();
                        dataTableProjectUnit = client.SelectUnitByProject(projectName);
                        dataGridViewProjectUnit.DataSource = dataTableProjectUnit;


                        //dataTableProjectSensor = client.SelectProjectSensorByProjectUnit();
                        //dataGridViewProjectSensor.DataSource = dataTableProjectSensor;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void dataGridViewProjectUnit_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    if (dataGridViewProjectUnit.Rows.Count > 0)
                    {
                        dataRowProjectUnit = dataTableProjectUnit.Rows[e.Row.Index];
                        //断面是直接和项目绑定的
                        int projectUnitID = Convert.ToInt32(dataRowProjectUnit["断面编号"]);
                        ServiceClient client = new ServiceClient();
                        dataTableProjectSensor = client.SelectProjectSensorByProjectUnit(projectUnitID);
                        dataGridViewProjectSensor.DataSource = dataTableProjectSensor;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }


    }
}
