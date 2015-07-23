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
            this.buttonProjectDeviceChannelToProjectSensor = new System.Windows.Forms.Button();
            this.groupBoxRelation = new System.Windows.Forms.GroupBox();
            this.groupBoxEntity = new System.Windows.Forms.GroupBox();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonProject = new System.Windows.Forms.Button();
            this.buttonDevice = new System.Windows.Forms.Button();
            this.groupBoxRelation.SuspendLayout();
            this.groupBoxEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUserToProject
            // 
            this.buttonUserToProject.Location = new System.Drawing.Point(19, 27);
            this.buttonUserToProject.Name = "buttonUserToProject";
            this.buttonUserToProject.Size = new System.Drawing.Size(121, 48);
            this.buttonUserToProject.TabIndex = 0;
            this.buttonUserToProject.Text = "用户名-->项目";
            this.buttonUserToProject.UseVisualStyleBackColor = true;
            this.buttonUserToProject.Click += new System.EventHandler(this.buttonUserToProject_Click);
            // 
            // buttonProjectToDevice
            // 
            this.buttonProjectToDevice.Location = new System.Drawing.Point(178, 27);
            this.buttonProjectToDevice.Name = "buttonProjectToDevice";
            this.buttonProjectToDevice.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectToDevice.TabIndex = 1;
            this.buttonProjectToDevice.Text = "项目名-->设备";
            this.buttonProjectToDevice.UseVisualStyleBackColor = true;
            this.buttonProjectToDevice.Click += new System.EventHandler(this.buttonProjectToDevice_Click);
            // 
            // buttonProjectToSensor
            // 
            this.buttonProjectToSensor.Location = new System.Drawing.Point(334, 27);
            this.buttonProjectToSensor.Name = "buttonProjectToSensor";
            this.buttonProjectToSensor.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectToSensor.TabIndex = 2;
            this.buttonProjectToSensor.Text = "项目名-->传感器";
            this.buttonProjectToSensor.UseVisualStyleBackColor = true;
            this.buttonProjectToSensor.Click += new System.EventHandler(this.buttonProjectToSensor_Click);
            // 
            // buttonProjectUnitSensor
            // 
            this.buttonProjectUnitSensor.Location = new System.Drawing.Point(19, 128);
            this.buttonProjectUnitSensor.Name = "buttonProjectUnitSensor";
            this.buttonProjectUnitSensor.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectUnitSensor.TabIndex = 3;
            this.buttonProjectUnitSensor.Text = "项目断面-->项目传感器";
            this.buttonProjectUnitSensor.UseVisualStyleBackColor = true;
            this.buttonProjectUnitSensor.Click += new System.EventHandler(this.buttonProjectUnitSensor_Click);
            // 
            // buttonProjectDeviceChannelToProjectSensor
            // 
            this.buttonProjectDeviceChannelToProjectSensor.Location = new System.Drawing.Point(178, 128);
            this.buttonProjectDeviceChannelToProjectSensor.Name = "buttonProjectDeviceChannelToProjectSensor";
            this.buttonProjectDeviceChannelToProjectSensor.Size = new System.Drawing.Size(121, 48);
            this.buttonProjectDeviceChannelToProjectSensor.TabIndex = 4;
            this.buttonProjectDeviceChannelToProjectSensor.Text = "项目设备通道-->项目传感器";
            this.buttonProjectDeviceChannelToProjectSensor.UseVisualStyleBackColor = true;
            this.buttonProjectDeviceChannelToProjectSensor.Click += new System.EventHandler(this.buttonProjectDeviceChannelToProjectSensor_Click);
            // 
            // groupBoxRelation
            // 
            this.groupBoxRelation.Controls.Add(this.buttonProjectDeviceChannelToProjectSensor);
            this.groupBoxRelation.Controls.Add(this.buttonUserToProject);
            this.groupBoxRelation.Controls.Add(this.buttonProjectUnitSensor);
            this.groupBoxRelation.Controls.Add(this.buttonProjectToDevice);
            this.groupBoxRelation.Controls.Add(this.buttonProjectToSensor);
            this.groupBoxRelation.Location = new System.Drawing.Point(12, 214);
            this.groupBoxRelation.Name = "groupBoxRelation";
            this.groupBoxRelation.Size = new System.Drawing.Size(687, 196);
            this.groupBoxRelation.TabIndex = 5;
            this.groupBoxRelation.TabStop = false;
            this.groupBoxRelation.Text = "关联";
            // 
            // groupBoxEntity
            // 
            this.groupBoxEntity.Controls.Add(this.buttonDevice);
            this.groupBoxEntity.Controls.Add(this.buttonProject);
            this.groupBoxEntity.Controls.Add(this.buttonUser);
            this.groupBoxEntity.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEntity.Name = "groupBoxEntity";
            this.groupBoxEntity.Size = new System.Drawing.Size(687, 196);
            this.groupBoxEntity.TabIndex = 6;
            this.groupBoxEntity.TabStop = false;
            this.groupBoxEntity.Text = "实体";
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(19, 20);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(96, 48);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "用户";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonProject
            // 
            this.buttonProject.Location = new System.Drawing.Point(152, 20);
            this.buttonProject.Name = "buttonProject";
            this.buttonProject.Size = new System.Drawing.Size(96, 48);
            this.buttonProject.TabIndex = 2;
            this.buttonProject.Text = "项目";
            this.buttonProject.UseVisualStyleBackColor = true;
            this.buttonProject.Click += new System.EventHandler(this.buttonProject_Click);
            // 
            // buttonDevice
            // 
            this.buttonDevice.Location = new System.Drawing.Point(302, 20);
            this.buttonDevice.Name = "buttonDevice";
            this.buttonDevice.Size = new System.Drawing.Size(96, 48);
            this.buttonDevice.TabIndex = 3;
            this.buttonDevice.Text = "设备";
            this.buttonDevice.UseVisualStyleBackColor = true;
            this.buttonDevice.Click += new System.EventHandler(this.buttonDevice_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 546);
            this.Controls.Add(this.groupBoxEntity);
            this.Controls.Add(this.groupBoxRelation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.groupBoxRelation.ResumeLayout(false);
            this.groupBoxEntity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserToProject;
        private System.Windows.Forms.Button buttonProjectToDevice;
        private System.Windows.Forms.Button buttonProjectToSensor;
        private System.Windows.Forms.Button buttonProjectUnitSensor;
        private System.Windows.Forms.Button buttonProjectDeviceChannelToProjectSensor;
        private System.Windows.Forms.GroupBox groupBoxRelation;
        private System.Windows.Forms.GroupBox groupBoxEntity;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonProject;
        private System.Windows.Forms.Button buttonDevice;


    }
}

