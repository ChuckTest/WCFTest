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

namespace YunClient.Entity
{
    public partial class FormUser : Form
    {
        private DataTable dataTableUser;

        public FormUser()
        {
            InitializeComponent();
            try
            {
                ZBMDataGridView.Config(dataGridViewUser);
                LoadUser();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void LoadUser()
        {
            ServiceClient client = new ServiceClient();
            dataTableUser = client.SelectUser();
            dataGridViewUser.DataSource = dataTableUser;
        }
    }
}
