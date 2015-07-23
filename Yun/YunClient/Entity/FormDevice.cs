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
    public partial class FormDevice : Form
    {
        private DataTable dataTableDevice;

        public FormDevice()
        {
            InitializeComponent();
            try
            {
                ZBMDataGridView.Config(dataGridViewDevice);
                LoadDevice();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void LoadDevice()
        {
            try
            {
                ServiceClient client = new ServiceClient();
                dataTableDevice = client.SelectDevice();
                dataGridViewDevice.DataSource = dataTableDevice;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }
    }
}
