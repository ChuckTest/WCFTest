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
        }

        private void buttonUserToProject_Click(object sender, EventArgs e)
        {
            try
            {
                FormUserToProject form = new FormUserToProject();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
            }
        }
    }
}
