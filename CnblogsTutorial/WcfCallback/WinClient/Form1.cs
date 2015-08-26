using System;
using System.ServiceModel;
using System.Windows.Forms;
using ServiceContracts;

namespace WinClient
{
    public partial class Form1 : Form
    {
        private IAddService channel;

        public Form1()
        {
            InitializeComponent();
            FormClosed += Form1_FormClosed;
            EventManager.Instance.DataArrived += Instance_DataArrived;
            ButtonStatus(true);
        }

        private void ButtonStatus(bool start)
        {
            buttonStart.Enabled = start;
            buttonStop.Enabled = !start;
        }

        private void Instance_DataArrived(object sender, DataArrivedEventArgs e)
        {
            try
            {
                Console.WriteLine(@"{0}:数据接收", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                textBoxResult.Invoke((MethodInvoker) delegate
                {
                    textBoxResult.AppendText(string.Join(",", e.List));
                    textBoxResult.AppendText(Environment.NewLine + Environment.NewLine);
                });
            }
            catch (Exception ex)
            {
                BeginInvoke((Action) delegate
                {
                    throw ex;
                });
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            var channelFactory = new DuplexChannelFactory<IAddService>(instanceContext, "AddService_Binding");
            channel = channelFactory.CreateChannel();

            string userName = textBoxUserName.Text.Trim();
            if (userName.Equals(string.Empty))
            {
                MessageBox.Show(@"用户名不允许为空");
            }
            else
            {
                ButtonStatus(false);
                channel.Login(userName);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ButtonStatus(true);
            CloseChannel();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseChannel();
        }

        private void CloseChannel()
        {
            IClientChannel tempChannel = channel as IClientChannel;
            if (tempChannel != null)
            {
                tempChannel.Close();
            }
        }
    }
}
