namespace WinClient
{
    partial class Form1
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
            this.cmdInvoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdInvoke
            // 
            this.cmdInvoke.Location = new System.Drawing.Point(60, 27);
            this.cmdInvoke.Name = "cmdInvoke";
            this.cmdInvoke.Size = new System.Drawing.Size(131, 23);
            this.cmdInvoke.TabIndex = 1;
            this.cmdInvoke.Text = "Invoke Service";
            this.cmdInvoke.UseVisualStyleBackColor = true;
            this.cmdInvoke.Click += new System.EventHandler(this.cmdInvoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 82);
            this.Controls.Add(this.cmdInvoke);
            this.Name = "Form1";
            this.Text = "Callback Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInvoke;
    }
}

