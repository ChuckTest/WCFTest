namespace YunClient.Entity
{
    partial class FormDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDevice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevice
            // 
            this.dataGridViewDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDevice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDevice.Name = "dataGridViewDevice";
            this.dataGridViewDevice.RowTemplate.Height = 23;
            this.dataGridViewDevice.Size = new System.Drawing.Size(889, 523);
            this.dataGridViewDevice.TabIndex = 0;
            // 
            // FormDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 523);
            this.Controls.Add(this.dataGridViewDevice);
            this.Name = "FormDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDevice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevice;
    }
}