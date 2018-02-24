using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyGitTest
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入姓名！");
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            if (txtName.Text.Trim() == "张三" && txtPwd.Text.Trim() == "123456")
            {
                Last l = new Last();
                this.Hide();
                l.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("请重新输入用户名或密码！");
            }
            

        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtName.Focus();
            txtPwd.Text = "";

        }
    }
}
