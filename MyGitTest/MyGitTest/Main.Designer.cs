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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.Location = new System.Drawing.Point(72, 298);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(98, 36);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "确 定";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(244, 298);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(96, 36);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "取 消";
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 95);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(157, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(142, 198);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPwd.Properties.Appearance.Options.UseFont = true;
            this.txtPwd.Size = new System.Drawing.Size(154, 26);
            this.txtPwd.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 389);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Name = "Main";
            this.Text = "主窗体";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnYes;
        private DevExpress.XtraEditors.SimpleButton BtnNo;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtPwd;
    }
}

