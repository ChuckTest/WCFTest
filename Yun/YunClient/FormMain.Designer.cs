namespace YunClient
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUserToProject = new System.Windows.Forms.Button();
            this.buttonProjectToDevice = new System.Windows.Forms.Button();
            this.buttonProjectToSensor = new System.Windows.Forms.Button();
            this.buttonProjectUnitSensor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserToProject
            // 
            this.buttonUserToProject.Location = new System.Drawing.Point(27, 25);
            this.buttonUserToProject.Name = "buttonUserToProject";
            this.buttonUserToProject.Size = new System.Drawing.Size(121, 48);
            this.buttonUserToProject.TabIndex = 0;
            this.buttonUserToProject.Text = "用户名-->项目";
            this.buttonUserToProject.UseVisualStyleBackColor = true;
            this.buttonUserToProject.Click += new System.EventHandler(this.buttonUserToProject_Click);
            // 
            // buttonProjectToDevice
            // 
            this.buttonProjectToDevice.Location = new System.Drawing.Point(186, 25);
            this.buttonProjectToDevice.Name = "buttonProjectToDevice";
            this.buttonProjectToDevice.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectToDevice.TabIndex = 1;
            this.buttonProjectToDevice.Text = "项目名-->设备";
            this.buttonProjectToDevice.UseVisualStyleBackColor = true;
            this.buttonProjectToDevice.Click += new System.EventHandler(this.buttonProjectToDevice_Click);
            // 
            // buttonProjectToSensor
            // 
            this.buttonProjectToSensor.Location = new System.Drawing.Point(342, 25);
            this.buttonProjectToSensor.Name = "buttonProjectToSensor";
            this.buttonProjectToSensor.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectToSensor.TabIndex = 2;
            this.buttonProjectToSensor.Text = "项目名-->传感器";
            this.buttonProjectToSensor.UseVisualStyleBackColor = true;
            this.buttonProjectToSensor.Click += new System.EventHandler(this.buttonProjectToSensor_Click);
            // 
            // buttonProjectUnitSensor
            // 
            this.buttonProjectUnitSensor.Location = new System.Drawing.Point(27, 126);
            this.buttonProjectUnitSensor.Name = "buttonProjectUnitSensor";
            this.buttonProjectUnitSensor.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectUnitSensor.TabIndex = 3;
            this.buttonProjectUnitSensor.Text = "项目断面-->项目传感器";
            this.buttonProjectUnitSensor.UseVisualStyleBackColor = true;
            this.buttonProjectUnitSensor.Click += new System.EventHandler(this.buttonProjectUnitSensor_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 546);
            this.Controls.Add(this.buttonProjectUnitSensor);
            this.Controls.Add(this.buttonProjectToSensor);
            this.Controls.Add(this.buttonProjectToDevice);
            this.Controls.Add(this.buttonUserToProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户名下的设备";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserToProject;
        private System.Windows.Forms.Button buttonProjectToDevice;
        private System.Windows.Forms.Button buttonProjectToSensor;
        private System.Windows.Forms.Button buttonProjectUnitSensor;


    }
}

