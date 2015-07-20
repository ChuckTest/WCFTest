using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinClientV1.localhost;

namespace WinClientV1
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
                string message = proxy.Operation1();
                MessageBox.Show(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ServiceAContractClient proxy = new ServiceAContractClient())
            {
                string message = proxy.Operation2();
                MessageBox.Show(message);
            }
        }
    }
}
