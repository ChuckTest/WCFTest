namespace YunClient
{
    partial class FormProjectUnitSensor
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
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.dataGridViewProjectSensor = new System.Windows.Forms.DataGridView();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGridViewProjectUnit = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewProject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 456);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(973, 3);
            this.splitter3.TabIndex = 11;
            this.splitter3.TabStop = false;
            // 
            // dataGridViewProjectSensor
            // 
            this.dataGridViewProjectSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProjectSensor.Location = new System.Drawing.Point(0, 306);
            this.dataGridViewProjectSensor.Name = "dataGridViewProjectSensor";
            this.dataGridViewProjectSensor.RowTemplate.Height = 23;
            this.dataGridViewProjectSensor.Size = new System.Drawing.Size(973, 150);
            this.dataGridViewProjectSensor.TabIndex = 10;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 303);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(973, 3);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // dataGridViewProjectUnit
            // 
            this.dataGridViewProjectUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProjectUnit.Location = new System.Drawing.Point(0, 153);
            this.dataGridViewProjectUnit.Name = "dataGridViewProjectUnit";
            this.dataGridViewProjectUnit.RowTemplate.Height = 23;
            this.dataGridViewProjectUnit.Size = new System.Drawing.Size(973, 150);
            this.dataGridViewProjectUnit.TabIndex = 8;
            this.dataGridViewProjectUnit.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewProjectUnit_RowStateChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 150);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(973, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewProject
            // 
            this.dataGridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProject.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProject.Name = "dataGridViewProject";
            this.dataGridViewProject.RowTemplate.Height = 23;
            this.dataGridViewProject.Size = new System.Drawing.Size(973, 150);
            this.dataGridViewProject.TabIndex = 6;
            this.dataGridViewProject.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewProject_RowStateChanged);
            // 
            // FormProjectUnitSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 461);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.dataGridViewProjectSensor);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.dataGridViewProjectUnit);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridViewProject);
            this.Name = "FormProjectUnitSensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProjectUnitSensor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.DataGridView dataGridViewProjectSensor;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridViewProjectUnit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewProject;
    }
}