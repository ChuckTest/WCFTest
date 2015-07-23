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
    public partial class FormSensor : Form
    {
        private DataTable dataTableSensor;

        public FormSensor()
        {
            InitializeComponent();
            try
            {
                ZBMDataGridView.Config(dataGridViewSensor);
                LoadSensor();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void LoadSensor()
        {
            try
            {
                ServiceClient client = new ServiceClient();
                dataTableSensor = client.SelectSensor();
                dataGridViewSensor.DataSource = dataTableSensor;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }
    }
}
