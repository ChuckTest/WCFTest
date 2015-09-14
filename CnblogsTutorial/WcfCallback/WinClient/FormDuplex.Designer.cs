using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinClient
{
    partial class FormDuplex
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.groupBoxProtocol = new System.Windows.Forms.GroupBox();
            this.radioButtonNetTcpBinding = new System.Windows.Forms.RadioButton();
            this.radioButtonWsDualHttpBinding = new System.Windows.Forms.RadioButton();
            this.groupBoxProtocol.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(330, 36);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(458, 36);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "结束";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(35, 76);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(668, 345);
            this.textBoxResult.TabIndex = 2;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(608, 34);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "清屏";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(215, 38);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.Text = "ChuckLu";
            // 
            // groupBoxProtocol
            // 
            this.groupBoxProtocol.Controls.Add(this.radioButtonWsDualHttpBinding);
            this.groupBoxProtocol.Controls.Add(this.radioButtonNetTcpBinding);
            this.groupBoxProtocol.Location = new System.Drawing.Point(35, 12);
            this.groupBoxProtocol.Name = "groupBoxProtocol";
            this.groupBoxProtocol.Size = new System.Drawing.Size(171, 58);
            this.groupBoxProtocol.TabIndex = 5;
            this.groupBoxProtocol.TabStop = false;
            this.groupBoxProtocol.Text = "协议";
            // 
            // radioButtonNetTcpBinding
            // 
            this.radioButtonNetTcpBinding.AutoSize = true;
            this.radioButtonNetTcpBinding.Location = new System.Drawing.Point(106, 25);
            this.radioButtonNetTcpBinding.Name = "radioButtonNetTcpBinding";
            this.radioButtonNetTcpBinding.Size = new System.Drawing.Size(59, 16);
            this.radioButtonNetTcpBinding.TabIndex = 0;
            this.radioButtonNetTcpBinding.Text = "netTcp";
            this.radioButtonNetTcpBinding.UseVisualStyleBackColor = true;
            // 
            // radioButtonWsDualHttpBinding
            // 
            this.radioButtonWsDualHttpBinding.AutoSize = true;
            this.radioButtonWsDualHttpBinding.Checked = true;
            this.radioButtonWsDualHttpBinding.Location = new System.Drawing.Point(6, 24);
            this.radioButtonWsDualHttpBinding.Name = "radioButtonWsDualHttpBinding";
            this.radioButtonWsDualHttpBinding.Size = new System.Drawing.Size(83, 16);
            this.radioButtonWsDualHttpBinding.TabIndex = 1;
            this.radioButtonWsDualHttpBinding.TabStop = true;
            this.radioButtonWsDualHttpBinding.Text = "wsDualHttp";
            this.radioButtonWsDualHttpBinding.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 448);
            this.Controls.Add(this.groupBoxProtocol);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxProtocol.ResumeLayout(false);
            this.groupBoxProtocol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private TextBox textBoxResult;
        private Button buttonClear;
        private TextBox textBoxUserName;
        private GroupBox groupBoxProtocol;
        private RadioButton radioButtonWsDualHttpBinding;
        private RadioButton radioButtonNetTcpBinding;
    }
}

