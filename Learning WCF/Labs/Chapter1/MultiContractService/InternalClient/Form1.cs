using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessServiceContracts;
using System.ServiceModel;

namespace InternalClient
{
    public partial class Form1 : Form
    {
        IServiceA proxyA;
        IAdmin adminProxyA;

        IServiceB proxyB;
        IAdmin adminProxyB;

        string message = string.Empty;

        public Form1()
        {
            InitializeComponent();
            CreacteProxy();
        }

        private void CreacteProxy()
        {
            //IServiceA和IServiceB对应的终结点只有1个，无需通过终结点的名称来区分
            //**务必注意，这里ChannelFactory<TChannel>泛型类的构造函数必须填写参数;否则之后创建信道的时候，会提示地址不存在
            ChannelFactory<IServiceA> factoryA = new ChannelFactory<IServiceA>(string.Empty);
            ChannelFactory<IServiceB> factoryB = new ChannelFactory<IServiceB>(string.Empty);

            //IAdmin有2个终结点，所以需要通过终结点的名字来区分
            ChannelFactory<IAdmin> adminFactoryA = new ChannelFactory<IAdmin>("TCP_IAdmin");
            ChannelFactory<IAdmin> adminFactoryB = new ChannelFactory<IAdmin>("IPC_IAdmin");

            proxyA = factoryA.CreateChannel();
            adminProxyA = adminFactoryA.CreateChannel();

            proxyB = factoryB.CreateChannel();
            adminProxyB = adminFactoryB.CreateChannel();
        }

        private void buttonServiceA_AdminOperation1_Click(object sender, EventArgs e)
        {
            try
            {
                message = adminProxyA.AdminOperation1();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonServiceA_AdminOperation2_Click(object sender, EventArgs e)
        {
            message = adminProxyA.AdminOperation2();
            MessageBox.Show(message);
        }

        private void buttonServiceB_AdminOperation1_Click(object sender, EventArgs e)
        {
            message = adminProxyB.AdminOperation1();
            MessageBox.Show(message);
        }

        private void buttonServiceB_AdminOperation2_Click(object sender, EventArgs e)
        {
            message = adminProxyB.AdminOperation2();
            MessageBox.Show(message);
        }

        private void buttonServiceA_Operation1_Click(object sender, EventArgs e)
        {
            message = proxyA.Operation1();
            MessageBox.Show(message);
        }

        private void buttonServiceA_Operation2_Click(object sender, EventArgs e)
        {
            message = proxyA.Operation2();
            MessageBox.Show(message);
        }

        private void buttonServiceA_Operation3_Click(object sender, EventArgs e)
        {
            message = proxyB.Operation3();
            MessageBox.Show(message);
        }

        private void CloseProxy(ICommunicationObject proxy)
        {
            if (proxy != null)
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                }
                else
                {
                    proxy.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProxy(proxyA as ICommunicationObject);
            CloseProxy(adminProxyA as ICommunicationObject);
            CloseProxy(proxyB as ICommunicationObject);
            CloseProxy(adminProxyB as ICommunicationObject);
        }
    }
}
