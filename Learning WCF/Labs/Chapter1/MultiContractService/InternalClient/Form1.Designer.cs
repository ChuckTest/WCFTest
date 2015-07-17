namespace InternalClient
{
    partial class Form1
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
            this.buttonServiceA_AdminOperation1 = new System.Windows.Forms.Button();
            this.buttonServiceA_AdminOperation2 = new System.Windows.Forms.Button();
            this.buttonServiceB_AdminOperation1 = new System.Windows.Forms.Button();
            this.buttonServiceB_AdminOperation2 = new System.Windows.Forms.Button();
            this.buttonServiceA_Operation1 = new System.Windows.Forms.Button();
            this.buttonServiceA_Operation2 = new System.Windows.Forms.Button();
            this.buttonServiceA_Operation3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonServiceA_AdminOperation1
            // 
            this.buttonServiceA_AdminOperation1.Location = new System.Drawing.Point(44, 35);
            this.buttonServiceA_AdminOperation1.Name = "buttonServiceA_AdminOperation1";
            this.buttonServiceA_AdminOperation1.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceA_AdminOperation1.TabIndex = 0;
            this.buttonServiceA_AdminOperation1.Text = "ServiceA.AdminOperation1";
            this.buttonServiceA_AdminOperation1.UseVisualStyleBackColor = true;
            this.buttonServiceA_AdminOperation1.Click += new System.EventHandler(this.buttonServiceA_AdminOperation1_Click);
            // 
            // buttonServiceA_AdminOperation2
            // 
            this.buttonServiceA_AdminOperation2.Location = new System.Drawing.Point(44, 64);
            this.buttonServiceA_AdminOperation2.Name = "buttonServiceA_AdminOperation2";
            this.buttonServiceA_AdminOperation2.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceA_AdminOperation2.TabIndex = 1;
            this.buttonServiceA_AdminOperation2.Text = "ServiceA.AdminOperation2";
            this.buttonServiceA_AdminOperation2.UseVisualStyleBackColor = true;
            this.buttonServiceA_AdminOperation2.Click += new System.EventHandler(this.buttonServiceA_AdminOperation2_Click);
            // 
            // buttonServiceB_AdminOperation1
            // 
            this.buttonServiceB_AdminOperation1.Location = new System.Drawing.Point(44, 93);
            this.buttonServiceB_AdminOperation1.Name = "buttonServiceB_AdminOperation1";
            this.buttonServiceB_AdminOperation1.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceB_AdminOperation1.TabIndex = 2;
            this.buttonServiceB_AdminOperation1.Text = "ServiceB.AdminOperation1";
            this.buttonServiceB_AdminOperation1.UseVisualStyleBackColor = true;
            this.buttonServiceB_AdminOperation1.Click += new System.EventHandler(this.buttonServiceB_AdminOperation1_Click);
            // 
            // buttonServiceB_AdminOperation2
            // 
            this.buttonServiceB_AdminOperation2.Location = new System.Drawing.Point(44, 122);
            this.buttonServiceB_AdminOperation2.Name = "buttonServiceB_AdminOperation2";
            this.buttonServiceB_AdminOperation2.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceB_AdminOperation2.TabIndex = 3;
            this.buttonServiceB_AdminOperation2.Text = "ServiceB.AdminOperation2";
            this.buttonServiceB_AdminOperation2.UseVisualStyleBackColor = true;
            this.buttonServiceB_AdminOperation2.Click += new System.EventHandler(this.buttonServiceB_AdminOperation2_Click);
            // 
            // buttonServiceA_Operation1
            // 
            this.buttonServiceA_Operation1.Location = new System.Drawing.Point(44, 171);
            this.buttonServiceA_Operation1.Name = "buttonServiceA_Operation1";
            this.buttonServiceA_Operation1.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceA_Operation1.TabIndex = 4;
            this.buttonServiceA_Operation1.Text = "ServiceA.Operation1";
            this.buttonServiceA_Operation1.UseVisualStyleBackColor = true;
            this.buttonServiceA_Operation1.Click += new System.EventHandler(this.buttonServiceA_Operation1_Click);
            // 
            // buttonServiceA_Operation2
            // 
            this.buttonServiceA_Operation2.Location = new System.Drawing.Point(44, 198);
            this.buttonServiceA_Operation2.Name = "buttonServiceA_Operation2";
            this.buttonServiceA_Operation2.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceA_Operation2.TabIndex = 5;
            this.buttonServiceA_Operation2.Text = "ServiceA.Operation2";
            this.buttonServiceA_Operation2.UseVisualStyleBackColor = true;
            this.buttonServiceA_Operation2.Click += new System.EventHandler(this.buttonServiceA_Operation2_Click);
            // 
            // buttonServiceA_Operation3
            // 
            this.buttonServiceA_Operation3.Location = new System.Drawing.Point(44, 227);
            this.buttonServiceA_Operation3.Name = "buttonServiceA_Operation3";
            this.buttonServiceA_Operation3.Size = new System.Drawing.Size(164, 23);
            this.buttonServiceA_Operation3.TabIndex = 6;
            this.buttonServiceA_Operation3.Text = "ServiceB.Operation3";
            this.buttonServiceA_Operation3.UseVisualStyleBackColor = true;
            this.buttonServiceA_Operation3.Click += new System.EventHandler(this.buttonServiceA_Operation3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonServiceA_Operation3);
            this.Controls.Add(this.buttonServiceA_Operation2);
            this.Controls.Add(this.buttonServiceA_Operation1);
            this.Controls.Add(this.buttonServiceB_AdminOperation2);
            this.Controls.Add(this.buttonServiceB_AdminOperation1);
            this.Controls.Add(this.buttonServiceA_AdminOperation2);
            this.Controls.Add(this.buttonServiceA_AdminOperation1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonServiceA_AdminOperation1;
        private System.Windows.Forms.Button buttonServiceA_AdminOperation2;
        private System.Windows.Forms.Button buttonServiceB_AdminOperation1;
        private System.Windows.Forms.Button buttonServiceB_AdminOperation2;
        private System.Windows.Forms.Button buttonServiceA_Operation1;
        private System.Windows.Forms.Button buttonServiceA_Operation2;
        private System.Windows.Forms.Button buttonServiceA_Operation3;
    }
}

