using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExternalClient.ServiceA;
using ExternalClient.ServiceB;
using System.ServiceModel;

namespace ExternalClient
{
    public partial class Form1 : Form
    {
        ServiceAClient proxyA;
        ServiceBClient proxyB;
        string message = string.Empty;

        public Form1()
        {
            InitializeComponent();
            InitProxy();
        }

        private void InitProxy()
        {
            //传递的参数是endpoint的名字
            proxyA = new ServiceAClient("BasicHttpBinding_IServiceA");
            proxyB = new ServiceBClient("BasicHttpBinding_IServiceB");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ServiceAClient和ServiceBClient继承自ClientBase<TChannel>类
            CloseProxy(proxyA as ICommunicationObject);
            CloseProxy(proxyB as ICommunicationObject);
        }

        private void CloseProxy(ICommunicationObject proxy)
        {
            if (proxy == null)
            {
                throw new ArgumentNullException();
            }
            if (proxy.State == CommunicationState.Faulted)
            {
                proxy.Abort();
            }
            else
            {
                proxy.Close();
            }
        }

        private void buttonOperation1_Click(object sender, EventArgs e)
        {
            message = proxyA.Operation1();
            MessageBox.Show(message);
        }

        private void buttonOperation2_Click(object sender, EventArgs e)
        {
            message = proxyA.Operation2();
            MessageBox.Show(message);
        }

        private void buttonOperation3_Click(object sender, EventArgs e)
        {
            message = proxyB.Operation3();
            MessageBox.Show(message);
        }
    }
}
