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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 546);
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


    }
}

