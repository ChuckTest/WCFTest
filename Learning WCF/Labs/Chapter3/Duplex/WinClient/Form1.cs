// ?2007 Michele Leroux Bustamante. All rights reserved 
// Book: Learning WCF, O'Reilly
// Book Blog: www.thatindigogirl.com
// Michele's Blog: www.dasblonde.net
// IDesign: www.idesign.net

using System;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using WinClient.localhost;

namespace WinClient
{
    /// <summary>
    /// Form1直接实现回调接口
    /// UseSynchronizationContext设置为false的目的fix the deadlock problem by instructing the callback endpoint to run on a separate thread from the UI thread
    /// </summary>
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form, HelloIndigoContractCallback
    {
        private HelloIndigoContractClient client = null;
        public Form1()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
            InstanceContext instanceContext = new InstanceContext(this);
            client = new HelloIndigoContractClient(instanceContext);
        }

        private void cmdInvoke_Click(object sender, EventArgs e)
        {
            client.HelloIndigo("Hello from WinClient");
        }

        /// <summary>
        /// 服务端回调客户端
        /// </summary>
        /// <param name="message"></param>
        public void HelloIndigoCallback(string message)
        {
            MessageBox.Show(string.Format("Received callback on thread {0}. {1}", Thread.CurrentThread.GetHashCode(),
                message));
        }
    }
}