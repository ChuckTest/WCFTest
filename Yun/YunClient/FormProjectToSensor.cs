using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZBM.Utility;
using ZBM.ZITaker.Log;
using YunClient.localhost;

namespace YunClient
{
    public partial class FormProjectToSensor : Form
    {
        public FormProjectToSensor()
        {
            InitializeComponent();
            ZBMDataGridView.Config(dataGridViewSensor);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = textBoxProjectName.Text.Trim();
                if (projectName.Equals(string.Empty))
                {
                    ZBMMessageBox.ShowInfo("请输入项目名");
                    return;
                }
                ServiceClient client = new ServiceClient();
                DataTable dataTable = client.SelectSensorByProject(projectName);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewSensor.DataSource = dataTable;
                    }
                    else
                    {
                        ZBMMessageBox.ShowInfo("此项目名下不存在传感器");
                    }
                }
                else
                {
                    ZBMMessageBox.ShowInfo("查找失败");
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
