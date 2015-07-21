namespace YunClient
{
    partial class FormProjectToDevice
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDevice
            // 
            this.dataGridViewDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevice.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewDevice.Name = "dataGridViewDevice";
            this.dataGridViewDevice.RowTemplate.Height = 23;
            this.dataGridViewDevice.Size = new System.Drawing.Size(682, 475);
            this.dataGridViewDevice.TabIndex = 11;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(613, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "查找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(87, 17);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(195, 21);
            this.textBoxProjectName.TabIndex = 9;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(21, 22);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(41, 12);
            this.labelProjectName.TabIndex = 8;
            this.labelProjectName.Text = "项目名";
            // 
            // FormProjectToDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 548);
            this.Controls.Add(this.dataGridViewDevice);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxProjectName);
            this.Controls.Add(this.labelProjectName);
            this.Name = "FormProjectToDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProjectToDevice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDevice;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Label labelProjectName;
    }
}