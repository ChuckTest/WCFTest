using System;
using System.Diagnostics;
using System.ServiceModel;
using System.Windows.Forms;
using ServiceContracts;

namespace WinClient
{
    public partial class FormProcess : Form
    {
        public FormProcess()
        {
            InitializeComponent();
        }

        private void buttonBrower_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = @"Execute files (*.exe)|*.exe|All files (*.*)|*.*";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBoxFileName.Text = openFileDialog1.FileName;
            }
        }

        private void buttonStartProcess_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text.Equals(string.Empty))
            {
                MessageBox.Show(@"请选择需要打开的exe文件", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());
            var channelFactory = new DuplexChannelFactory<IAddService>(instanceContext, "AddService_netTcpBinding");
            var channel = channelFactory.CreateChannel();
            channel.StartProcess(textBoxFileName.Text);
        }
    }
}
