using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZBM.Utility;
using YunClient.localhost;
using ZBM.ZITaker.Log;

namespace YunClient
{
    public partial class FormProjectToDevice : Form
    {
        public FormProjectToDevice()
        {
            InitializeComponent();
            ZBMDataGridView.Config(dataGridViewDevice);
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
                DataTable dataTable = client.SelectDeviceByProject(projectName);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewDevice.DataSource = dataTable;
                    }
                    else
                    {
                        ZBMMessageBox.ShowInfo("此项目名下不存在设备");
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
