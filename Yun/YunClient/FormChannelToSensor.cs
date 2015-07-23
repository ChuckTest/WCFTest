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
    public partial class FormChannelToSensor : Form
    {
        private DataTable dataTableProject;
        private DataRow dataRowProject;

        private DataTable dataTableDevice;
        private DataRow dataRowDevice;

        private DataTable dataTableChannelSensor;

        public FormChannelToSensor()
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

        private void DataGridViewSetting()
        {
            ZBMDataGridView.Config(dataGridViewProject);
            ZBMDataGridView.Config(dataGridViewProjectDevice);
            ZBMDataGridView.Config(dataGridViewChannelSensor);
        }

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

        private void dataGridViewProject_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    if (dataGridViewProject.Rows.Count > 0)
                    {
                        dataRowProject = dataTableProject.Rows[e.Row.Index];
                        string projectName = Convert.ToString(dataRowProject["ProjectName"]);

                        ServiceClient client = new ServiceClient();
                        dataTableDevice = client.SelectDeviceByProject(projectName);
                        dataGridViewProjectDevice.DataSource = dataTableDevice;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void dataGridViewProjectDevice_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    if (dataTableDevice.Rows.Count > 0)
                    {
                        dataRowDevice = dataTableDevice.Rows[e.Row.Index];
                        int projectDeviceID = Convert.ToInt32(dataRowDevice["ID"]);
                        ServiceClient client=new ServiceClient();
                        dataTableChannelSensor = client.SelectChannelSensorByProjectDevice(projectDeviceID);
                        dataGridViewChannelSensor.DataSource = dataTableChannelSensor;
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
