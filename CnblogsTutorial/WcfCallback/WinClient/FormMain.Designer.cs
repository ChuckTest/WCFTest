namespace WinClient
{
    partial class FormMain
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
            this.buttonDuplex = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDuplex
            // 
            this.buttonDuplex.Location = new System.Drawing.Point(58, 46);
            this.buttonDuplex.Name = "buttonDuplex";
            this.buttonDuplex.Size = new System.Drawing.Size(118, 54);
            this.buttonDuplex.TabIndex = 0;
            this.buttonDuplex.Text = "双工通讯";
            this.buttonDuplex.UseVisualStyleBackColor = true;
            this.buttonDuplex.Click += new System.EventHandler(this.buttonDuplex_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(232, 46);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(118, 54);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "启动进程";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 456);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonDuplex);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDuplex;
        private System.Windows.Forms.Button buttonProcess;
    }
}