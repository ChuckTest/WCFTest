using System;
using System.Globalization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using System.Windows.Forms;
using Services;

namespace WinHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string format = "{0}:{1}{2}";
        private ServiceHost serviceHost;

        private void AppendText(string message)
        {
            textBoxLog.AppendText(string.Format(format, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), message,
                Environment.NewLine));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            AppendText("启动服务");
            serviceHost = new ServiceHost(typeof (AddService));
            serviceHost.Open();
            foreach (ServiceEndpoint serviceEndpoint in serviceHost.Description.Endpoints)
            {
                AppendText(serviceEndpoint.Address.ToString());
            }
            AppendText("服务启动成功");
            EnableButton(true);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            AppendText("关闭服务"); 
            EnableButton(false);
        }

        private void EnableButton(bool start)
        {
            buttonStart.Enabled = !start;
            buttonStop.Enabled = start;
        }
    }
}
