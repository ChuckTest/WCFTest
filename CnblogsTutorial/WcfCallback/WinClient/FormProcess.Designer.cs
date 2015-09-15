namespace WinClient
{
    partial class FormProcess
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
            this.labelFileName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrower = new System.Windows.Forms.Button();
            this.buttonStartProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(61, 52);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(53, 12);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "文件名：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(120, 49);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(374, 21);
            this.textBoxFileName.TabIndex = 1;
            // 
            // buttonBrower
            // 
            this.buttonBrower.Location = new System.Drawing.Point(516, 47);
            this.buttonBrower.Name = "buttonBrower";
            this.buttonBrower.Size = new System.Drawing.Size(75, 23);
            this.buttonBrower.TabIndex = 2;
            this.buttonBrower.Text = "浏览";
            this.buttonBrower.UseVisualStyleBackColor = true;
            this.buttonBrower.Click += new System.EventHandler(this.buttonBrower_Click);
            // 
            // buttonStartProcess
            // 
            this.buttonStartProcess.Location = new System.Drawing.Point(63, 110);
            this.buttonStartProcess.Name = "buttonStartProcess";
            this.buttonStartProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonStartProcess.TabIndex = 3;
            this.buttonStartProcess.Text = "启动";
            this.buttonStartProcess.UseVisualStyleBackColor = true;
            this.buttonStartProcess.Click += new System.EventHandler(this.buttonStartProcess_Click);
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 515);
            this.Controls.Add(this.buttonStartProcess);
            this.Controls.Add(this.buttonBrower);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelFileName);
            this.Name = "FormProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonBrower;
        private System.Windows.Forms.Button buttonStartProcess;
    }
}