namespace MyGitTest
{
    partial class Main
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
            this.BtnYes = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNo = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(139, 330);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(98, 36);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "确 定";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.AutoSize = true;
            this.BtnNo.Location = new System.Drawing.Point(388, 330);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(96, 36);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "取 消";
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 476);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Name = "Main";
            this.Text = "主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnYes;
        private DevExpress.XtraEditors.SimpleButton BtnNo;
    }
}

