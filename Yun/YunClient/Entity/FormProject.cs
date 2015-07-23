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
    public partial class FormProject : Form
    {
        private DataTable dataTableProject;

        public FormProject()
        {
            InitializeComponent();
            try
            {
                ZBMDataGridView.Config(dataGridViewProject);
                LoadProject();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                throw;
            }
        }

        private void LoadProject()
        {
            ServiceClient client = new ServiceClient();
            dataTableProject = client.SelectProject();
            dataGridViewProject.DataSource = dataTableProject;
        }
    }
}
