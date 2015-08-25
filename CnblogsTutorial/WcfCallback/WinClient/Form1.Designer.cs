using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

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
            this.buttonStart = new Button();
            this.buttonStop = new Button();
            this.textBoxResult = new TextBox();
            this.buttonClear = new Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new Point(81, 35);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new Point(293, 35);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "结束";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new EventHandler(this.buttonStop_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new Point(35, 76);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = ScrollBars.Vertical;
            this.textBoxResult.Size = new Size(668, 345);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new Point(490, 34);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "清屏";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(730, 448);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private TextBox textBoxResult;
        private Button buttonClear;
    }
}

