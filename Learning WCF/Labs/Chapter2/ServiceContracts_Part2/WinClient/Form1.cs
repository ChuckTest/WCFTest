using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinClient.localhost;

namespace WinClient
{
    public partial class Form1 : Form
    {
        ServiceAClient proxy = new ServiceAClient();
        string message = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOperation1_Click(object sender, EventArgs e)
        {
            try
            {
                message = proxy.Operation1();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOperation2_Click(object sender, EventArgs e)
        {
            try
            {
                message = proxy.Operation2();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proxy != null)
            {
                proxy.Close();
            }
        }
    }
}
