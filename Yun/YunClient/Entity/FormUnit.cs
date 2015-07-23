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
    public partial class FormUnit : Form
    {
        private DataTable dataTableUnit;

        public FormUnit()
        {
            InitializeComponent();
            try
            {
                ZBMDataGridView.Config(dataGridViewUnit);
                LoadUnit();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void LoadUnit()
        {
            try
            {
                ServiceClient client = new ServiceClient();
                dataTableUnit = client.SelectUnit();
                dataGridViewUnit.DataSource = dataTableUnit;
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }
    }
}
