namespace ExternalClient
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
            this.buttonOperation1 = new System.Windows.Forms.Button();
            this.buttonOperation2 = new System.Windows.Forms.Button();
            this.buttonOperation3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOperation1
            // 
            this.buttonOperation1.Location = new System.Drawing.Point(98, 74);
            this.buttonOperation1.Name = "buttonOperation1";
            this.buttonOperation1.Size = new System.Drawing.Size(75, 23);
            this.buttonOperation1.TabIndex = 0;
            this.buttonOperation1.Text = "Operation1";
            this.buttonOperation1.UseVisualStyleBackColor = true;
            this.buttonOperation1.Click += new System.EventHandler(this.buttonOperation1_Click);
            // 
            // buttonOperation2
            // 
            this.buttonOperation2.Location = new System.Drawing.Point(98, 104);
            this.buttonOperation2.Name = "buttonOperation2";
            this.buttonOperation2.Size = new System.Drawing.Size(75, 23);
            this.buttonOperation2.TabIndex = 1;
            this.buttonOperation2.Text = "Operation2";
            this.buttonOperation2.UseVisualStyleBackColor = true;
            this.buttonOperation2.Click += new System.EventHandler(this.buttonOperation2_Click);
            // 
            // buttonOperation3
            // 
            this.buttonOperation3.Location = new System.Drawing.Point(98, 134);
            this.buttonOperation3.Name = "buttonOperation3";
            this.buttonOperation3.Size = new System.Drawing.Size(75, 23);
            this.buttonOperation3.TabIndex = 2;
            this.buttonOperation3.Text = "Operation3";
            this.buttonOperation3.UseVisualStyleBackColor = true;
            this.buttonOperation3.Click += new System.EventHandler(this.buttonOperation3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonOperation3);
            this.Controls.Add(this.buttonOperation2);
            this.Controls.Add(this.buttonOperation1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOperation1;
        private System.Windows.Forms.Button buttonOperation2;
        private System.Windows.Forms.Button buttonOperation3;
    }
}

