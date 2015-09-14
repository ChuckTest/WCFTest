using System;
using System.Windows.Forms;

namespace WinClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDuplex_Click(object sender, EventArgs e)
        {
            FormDuplex formDuplex = new FormDuplex();
            formDuplex.ShowDialog();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            FormProcess formProcess=new FormProcess();
            formProcess.ShowDialog();
        }
    }
}
