using System;
using System.Drawing;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Models;

namespace PosSystem.Forms
{
    /// <summary>
    /// 商品管理：以 DataGridView 列出商品，右側面板進行新增 / 修改 / 刪除，
    /// 支援關鍵字搜尋（名稱或條碼）。
    /// </summary>
    public partial class frmProduct : Form
    {
        private readonly ProductRepository _repo = new ProductRepository();
        private readonly CategoryRepository _catRepo = new CategoryRepository();

        // 目前編輯中的商品 Id；0 代表「新增模式」。
        private int _editingId = 0;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            ClearForm();
        }

        private void LoadCategories()
        {
            cboCategory.DataSource = _catRepo.GetAll();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = _repo.GetAll(txtSearch.Text.Trim());
            HighlightLowStock();
        }

        /// <summary>低庫存的列以紅字標示。</summary>
        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.DataBoundItem is Product p && p.IsLowStock)
                    row.DefaultCellStyle.ForeColor = Color.Firebrick;
            }
        }

        // ---- 搜尋 ----

        private void btnSearch_Click(object sender, EventArgs e) => LoadProducts();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
            ClearForm();
        }

        // ---- 選取列 → 帶入編輯面板 ----

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product p)
                FillForm(p);
        }

        private void FillForm(Product p)
        {
            _editingId = p.Id;
            txtBarcode.Text = p.Barcode;
            txtName.Text = p.Name;
            if (p.CategoryId > 0) cboCategory.SelectedValue = p.CategoryId;
            numPrice.Value = Clamp(numPrice, p.Price);
            numCost.Value = Clamp(numCost, p.Cost);
            numStock.Value = Clamp(numStock, p.Stock);
            numSafety.Value = Clamp(numSafety, p.SafetyStock);
            chkActive.Checked = p.IsActive;
            lblMode.Text = $"編輯模式（商品 #{p.Id}）";
            lblMode.ForeColor = Color.SteelBlue;
            btnDelete.Enabled = true;
        }

        private void ClearForm()
        {
            _editingId = 0;
            txtBarcode.Clear();
            txtName.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            numPrice.Value = 0;
            numCost.Value = 0;
            numStock.Value = 0;
            numSafety.Value = 0;
            chkActive.Checked = true;
            lblMode.Text = "新增模式";
            lblMode.ForeColor = Color.SeaGreen;
            btnDelete.Enabled = false;
            txtBarcode.Focus();
        }

        private static decimal Clamp(NumericUpDown n, decimal value)
        {
            if (value < n.Minimum) return n.Minimum;
            if (value > n.Maximum) return n.Maximum;
            return value;
        }

        // ---- 新增 / 儲存 / 刪除 ----

        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("請輸入商品名稱。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }

            var p = new Product
            {
                Id = _editingId,
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                CategoryId = cboCategory.SelectedValue is int cid ? cid : 0,
                Price = numPrice.Value,
                Cost = numCost.Value,
                Stock = (int)numStock.Value,
                SafetyStock = (int)numSafety.Value,
                IsActive = chkActive.Checked
            };

            try
            {
                if (_editingId == 0)
                {
                    _repo.Add(p);
                    MessageBox.Show("商品已新增。", "完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _repo.Update(p);
                    MessageBox.Show("商品已更新。", "完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadProducts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("儲存失敗：" + ex.Message + "\n（條碼可能重複）", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_editingId == 0) return;

            if (MessageBox.Show($"確定要刪除「{txtName.Text}」嗎？", "刪除確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                _repo.Delete(_editingId);
                LoadProducts();
                ClearForm();
            }
            catch (Exception)
            {
                // 商品已有交易紀錄（被外鍵參考）時無法刪除，建議改為下架
                if (MessageBox.Show(
                    "此商品已有銷售或進貨紀錄，無法直接刪除。\n是否改為「下架」（停止販售）？",
                    "無法刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var p = new Product
                    {
                        Id = _editingId,
                        Barcode = txtBarcode.Text.Trim(),
                        Name = txtName.Text.Trim(),
                        CategoryId = cboCategory.SelectedValue is int cid ? cid : 0,
                        Price = numPrice.Value,
                        Cost = numCost.Value,
                        Stock = (int)numStock.Value,
                        SafetyStock = (int)numSafety.Value,
                        IsActive = false
                    };
                    _repo.Update(p);
                    LoadProducts();
                    ClearForm();
                }
            }
        }
    }
}
