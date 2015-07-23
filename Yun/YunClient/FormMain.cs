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
using YunClient.Entity;
using YunClient.localhost;

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
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonProjectToDevice_Click(object sender, EventArgs e)
        {
            try
            {
                FormProjectToDevice form = new FormProjectToDevice();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonProjectToSensor_Click(object sender, EventArgs e)
        {
            try
            {
                FormProjectToSensor form = new FormProjectToSensor();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonProjectUnitSensor_Click(object sender, EventArgs e)
        {
            try
            {
                FormProjectUnitSensor form = new FormProjectUnitSensor();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonProjectDeviceChannelToProjectSensor_Click(object sender, EventArgs e)
        {
            try
            {
                FormChannelToSensor form = new FormChannelToSensor();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            try
            {
                FormUser form = new FormUser();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            try
            {
                FormProject form = new FormProject();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }

        private void buttonDevice_Click(object sender, EventArgs e)
        {
            try
            {
                FormDevice form = new FormDevice();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionLog.Instance.WriteLog(ex, LogType.UI);
                ZBMMessageBox.ShowError(ex);
            }
        }
    }
}
