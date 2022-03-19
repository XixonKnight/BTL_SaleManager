using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (username == "admin" && password == "admin")
                {
                    FormMain frmMain = new FormMain();
                    this.Hide();
                    frmMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thông tin tài khoản mật khẩu không chính xác!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
