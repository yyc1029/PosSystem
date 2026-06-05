using System;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Models;
using PosSystem.Services;

namespace PosSystem.Forms
{
    /// <summary>
    /// 員工帳號管理（僅管理員）：新增 / 修改 / 刪除帳號、設定角色與變更密碼。
    /// </summary>
    public partial class frmEmployee : Form
    {
        private readonly EmployeeRepository _repo = new EmployeeRepository();
        private int _editingId = 0;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("管理員");
            cboRole.Items.Add("收銀員");
            LoadEmployees();
            ClearForm();
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _repo.GetAll();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow?.DataBoundItem is Employee emp)
                FillForm(emp);
        }

        private void FillForm(Employee emp)
        {
            _editingId = emp.Id;
            txtUsername.Text = emp.Username;
            txtFullName.Text = emp.FullName;
            cboRole.SelectedIndex = emp.IsAdmin ? 0 : 1;
            txtPassword.Clear();
            lblMode.Text = "編輯模式（密碼留空＝不變更）";
            lblMode.ForeColor = System.Drawing.Color.SteelBlue;
            // 不可刪除目前登入中的自己
            btnDelete.Enabled = emp.Id != AuthService.CurrentUser.Id;
        }

        private void ClearForm()
        {
            _editingId = 0;
            txtUsername.Clear();
            txtFullName.Clear();
            cboRole.SelectedIndex = 1;   // 預設收銀員
            txtPassword.Clear();
            lblMode.Text = "新增模式";
            lblMode.ForeColor = System.Drawing.Color.SeaGreen;
            btnDelete.Enabled = false;
            txtUsername.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvEmployees.ClearSelection();
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("請輸入帳號。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string role = cboRole.SelectedIndex == 0 ? "Admin" : "Cashier";
            var emp = new Employee
            {
                Id = _editingId,
                Username = txtUsername.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = role
            };

            try
            {
                if (_editingId == 0)
                {
                    if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("新增帳號必須設定密碼。", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Focus();
                        return;
                    }
                    _repo.Add(emp, txtPassword.Text);
                    MessageBox.Show("帳號已新增。", "完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _repo.Update(emp);
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                        _repo.ChangePassword(_editingId, txtPassword.Text);
                    MessageBox.Show("帳號已更新。", "完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadEmployees();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message + "\n（帳號可能重複）", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_editingId == 0) return;
            if (_editingId == AuthService.CurrentUser.Id)
            {
                MessageBox.Show("不可刪除目前登入中的帳號。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"確定要刪除帳號「{txtUsername.Text}」嗎？", "刪除確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                _repo.Delete(_editingId);
                LoadEmployees();
                ClearForm();
            }
            catch (Exception)
            {
                MessageBox.Show("此帳號已有交易紀錄，無法刪除。", "無法刪除",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
