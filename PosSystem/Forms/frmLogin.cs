using System;
using System.Windows.Forms;
using PosSystem.Services;

namespace PosSystem.Forms
{
    /// <summary>登入畫面：驗證帳號密碼，成功後回傳 DialogResult.OK。</summary>
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入帳號與密碼。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AuthService.Login(username, password))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤，請重新輸入。", "登入失敗",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
