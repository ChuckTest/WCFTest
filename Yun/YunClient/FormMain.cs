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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ZBMDataGridView.Config(dataGridViewProject);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = textBoxUserName.Text.Trim();
                if (userName.Equals(string.Empty))
                {
                    ZBMMessageBox.ShowInfo("请输入用户名");
                    return;
                }
                ServiceClient client = new ServiceClient();
                DataTable dataTable = client.SelectProjectByUser(userName);
                if (dataTable != null)
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridViewProject.DataSource = dataTable;
                    }
                    else
                    {
                        ZBMMessageBox.ShowInfo("此用户名下不存在项目");
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
