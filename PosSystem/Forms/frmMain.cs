using System;
using System.Drawing;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Models;
using PosSystem.Services;

namespace PosSystem.Forms
{
    /// <summary>
    /// 主畫面（登入後的殼層）：左側導覽列依角色顯示功能，
    /// 中央儀表板顯示歡迎訊息與低庫存警示。
    /// </summary>
    public partial class frmMain : Form
    {
        private readonly ProductRepository _productRepo = new ProductRepository();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var user = AuthService.CurrentUser;
            lblWelcome.Text = $"歡迎，{user.FullName}（{user.RoleText}）";
            lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd dddd");

            // 依角色控制功能可見性：收銀員只能使用 POS 結帳與庫存查詢
            bool isAdmin = AuthService.IsAdmin;
            btnProduct.Visible = isAdmin;
            btnPurchase.Visible = isAdmin;
            btnEmployee.Visible = isAdmin;
            btnReport.Visible = isAdmin;

            // 「前往補貨」按鈕只開放給管理員（收銀員無進貨權限）
            colAction.Visible = isAdmin;
            lblLowStockHint.Visible = isAdmin;

            LoadLowStock();
        }

        /// <summary>載入低庫存清單到儀表板。</summary>
        private void LoadLowStock()
        {
            var low = _productRepo.GetLowStock();
            dgvLowStock.Rows.Clear();
            foreach (var p in low)
            {
                int idx = dgvLowStock.Rows.Add(p.Name, p.Stock, p.SafetyStock, "前往補貨");
                var row = dgvLowStock.Rows[idx];
                row.Tag = p.Id;   // 記住商品 Id，供補貨跳轉使用
                // 只把文字欄位標紅，按鈕維持原樣
                for (int c = 0; c < 3; c++)
                    row.Cells[c].Style.ForeColor = Color.Firebrick;
            }
            lblLowStockTitle.Text = low.Count > 0
                ? $"⚠ 低庫存警示（{low.Count} 項商品需補貨）"
                : "✓ 庫存狀況良好，目前沒有低庫存商品";
        }

        /// <summary>開啟進貨頁面並自動選好指定商品。</summary>
        private void OpenPurchaseFor(int productId)
        {
            if (!AuthService.IsAdmin) return;
            using (var f = new frmPurchase(productId)) f.ShowDialog();
            LoadLowStock();
        }

        // 點「前往補貨」按鈕
        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colAction.Index) return;
            if (dgvLowStock.Rows[e.RowIndex].Tag is int pid)
                OpenPurchaseFor(pid);
        }

        // 雙擊整列也可補貨
        private void dgvLowStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvLowStock.Rows[e.RowIndex].Tag is int pid)
                OpenPurchaseFor(pid);
        }

        // ---- 導覽按鈕 ----

        private void btnPos_Click(object sender, EventArgs e)
        {
            using (var f = new frmPos()) f.ShowDialog();
            LoadLowStock();   // 結帳後庫存可能變動，刷新警示
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            using (var f = new frmProduct()) f.ShowDialog();
            LoadLowStock();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            using (var f = new frmPurchase()) f.ShowDialog();
            LoadLowStock();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            using (var f = new frmInventory()) f.ShowDialog();
            LoadLowStock();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (var f = new frmReport()) f.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            using (var f = new frmEmployee()) f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要登出嗎？", "登出",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            AuthService.Logout();
            // 回到登入畫面
            DialogResult = DialogResult.Retry;   // 由 Program 判斷重新顯示登入
            Close();
        }
    }
}
