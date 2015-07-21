using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinClientV2.ServiceA2;

namespace WinClientV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())
            {
                string s = proxy.Operation1();
                MessageBox.Show(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())
            {
                string s = proxy.Operation2();
                MessageBox.Show(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())
            {
                string s = proxy.Operation3();
                MessageBox.Show(s);
            }
        }
    }
}
