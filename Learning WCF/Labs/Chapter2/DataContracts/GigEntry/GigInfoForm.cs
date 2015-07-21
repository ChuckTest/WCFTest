using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GigEntry.localhost;

namespace GigEntry
{
    public partial class GigInfoForm : Form
    {
        GigManagerServiceContractClient proxy = new GigManagerServiceContractClient();

        public GigInfoForm()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            LinkItem item = new LinkItem();
            item.ID = int.Parse(this.txtId.Text);
            item.Title = this.txtTitle.Text;
            item.Description = this.txtDescription.Text;
            item.DateStart = this.dtpStart.Value;
            item.DateEnd = this.dtpEnd.Value;
            item.Url = this.txtUrl.Text;

            proxy.SaveGig(item);
        }

        private void cmdGet_Click(object sender, EventArgs e)
        {
            LinkItem item = proxy.GetGig();
            if (item != null)
            {
                this.txtId.Text = item.ID.ToString();
                this.txtTitle.Text = item.Title;
                this.txtDescription.Text = item.Description;
                if (item.DateStart != DateTime.MinValue)
                {
                    this.dtpStart.Value = item.DateStart;
                }
                if (item.DateEnd != DateTime.MinValue)
                {
                    this.dtpEnd.Value = item.DateEnd;
                }
                this.txtUrl.Text = item.Url;
            }
        }
    }
}
