namespace YunClient
{
    partial class FormChannelToSensor
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
            this.dataGridViewChannelSensor = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGridViewProjectDevice = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewProject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChannelSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChannelSensor
            // 
            this.dataGridViewChannelSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChannelSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewChannelSensor.Location = new System.Drawing.Point(0, 279);
            this.dataGridViewChannelSensor.Name = "dataGridViewChannelSensor";
            this.dataGridViewChannelSensor.RowTemplate.Height = 23;
            this.dataGridViewChannelSensor.Size = new System.Drawing.Size(943, 136);
            this.dataGridViewChannelSensor.TabIndex = 14;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 276);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(943, 3);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // dataGridViewProjectDevice
            // 
            this.dataGridViewProjectDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProjectDevice.Location = new System.Drawing.Point(0, 142);
            this.dataGridViewProjectDevice.Name = "dataGridViewProjectDevice";
            this.dataGridViewProjectDevice.RowTemplate.Height = 23;
            this.dataGridViewProjectDevice.Size = new System.Drawing.Size(943, 134);
            this.dataGridViewProjectDevice.TabIndex = 10;
            this.dataGridViewProjectDevice.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewProjectDevice_RowStateChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 139);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(943, 3);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewProject
            // 
            this.dataGridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProject.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProject.Name = "dataGridViewProject";
            this.dataGridViewProject.RowTemplate.Height = 23;
            this.dataGridViewProject.Size = new System.Drawing.Size(943, 139);
            this.dataGridViewProject.TabIndex = 8;
            this.dataGridViewProject.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewProject_RowStateChanged);
            // 
            // FormChannelToSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 417);
            this.Controls.Add(this.dataGridViewChannelSensor);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.dataGridViewProjectDevice);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridViewProject);
            this.Name = "FormChannelToSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChannelToSensor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChannelSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChannelSensor;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridViewProjectDevice;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewProject;

    }
}