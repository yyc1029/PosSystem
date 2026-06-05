using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Models;
using PosSystem.Services;

namespace PosSystem.Forms
{
    /// <summary>
    /// POS 結帳（核心模組）：
    /// 左側挑選商品（雙擊或掃條碼加入），右側購物車計算金額，
    /// 結帳時於單一交易內寫入銷售單、明細並扣減庫存，並計算找零。
    /// </summary>
    public partial class frmPos : Form
    {
        private readonly ProductRepository _productRepo = new ProductRepository();
        private readonly SaleRepository _saleRepo = new SaleRepository();
        private readonly List<SaleItem> _cart = new List<SaleItem>();

        // 商品目前庫存對照表（加入購物車時用來檢查是否超賣）
        private Dictionary<int, int> _stockMap = new Dictionary<int, int>();

        public frmPos()
        {
            InitializeComponent();
        }

        private void frmPos_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshCart();
            txtBarcode.Focus();
        }

        private void LoadProducts()
        {
            var products = _productRepo.GetAll(txtSearch.Text.Trim(), activeOnly: true);
            _stockMap = products.ToDictionary(p => p.Id, p => p.Stock);
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        // ---- 加入商品 ----

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProducts.Rows[e.RowIndex].DataBoundItem is Product p)
                AddToCart(p);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;

            string code = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(code)) return;

            var p = _productRepo.GetByBarcode(code);
            if (p == null)
            {
                MessageBox.Show("找不到條碼對應的商品。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!_stockMap.ContainsKey(p.Id)) _stockMap[p.Id] = p.Stock;
                AddToCart(p);
            }
            txtBarcode.Clear();
            txtBarcode.Focus();
        }

        private void AddToCart(Product p)
        {
            int stock = _stockMap.ContainsKey(p.Id) ? _stockMap[p.Id] : p.Stock;
            var existing = _cart.FirstOrDefault(i => i.ProductId == p.Id);
            int currentQty = existing?.Quantity ?? 0;

            if (currentQty + 1 > stock)
            {
                MessageBox.Show($"「{p.Name}」庫存不足（現有 {stock} 件）。", "庫存不足",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existing != null)
                existing.Quantity++;
            else
                _cart.Add(new SaleItem
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    UnitPrice = p.Price,
                    Quantity = 1
                });

            RefreshCart();
        }

        // ---- 購物車操作 ----

        private SaleItem SelectedCartItem =>
            dgvCart.CurrentRow?.DataBoundItem as SaleItem;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            var item = SelectedCartItem;
            if (item == null) return;
            int stock = _stockMap.ContainsKey(item.ProductId) ? _stockMap[item.ProductId] : int.MaxValue;
            if (item.Quantity + 1 > stock)
            {
                MessageBox.Show($"「{item.ProductName}」庫存不足（現有 {stock} 件）。", "庫存不足",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            item.Quantity++;
            RefreshCart();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var item = SelectedCartItem;
            if (item == null) return;
            item.Quantity--;
            if (item.Quantity <= 0)
                _cart.RemoveAll(i => i.ProductId == item.ProductId);
            RefreshCart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var item = SelectedCartItem;
            if (item == null) return;
            _cart.RemoveAll(i => i.ProductId == item.ProductId);
            RefreshCart();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            _cart.Clear();
            RefreshCart();
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart.ToList();
            lblTotal.Text = $"總計：$ {Total:N0}";
            UpdateChange();
            btnCheckout.Enabled = _cart.Count > 0;
        }

        private decimal Total => _cart.Sum(i => i.Subtotal);

        private void numPay_ValueChanged(object sender, EventArgs e) => UpdateChange();

        private void UpdateChange()
        {
            decimal change = numPay.Value - Total;
            if (change >= 0)
            {
                lblChange.Text = $"找零：$ {change:N0}";
                lblChange.ForeColor = System.Drawing.Color.SeaGreen;
            }
            else
            {
                lblChange.Text = $"不足：$ {-change:N0}";
                lblChange.ForeColor = System.Drawing.Color.Firebrick;
            }
        }

        // ---- 結帳 ----

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            if (numPay.Value < Total)
            {
                MessageBox.Show("實收金額不足，請重新輸入。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                numPay.Focus();
                return;
            }

            try
            {
                decimal pay = numPay.Value;
                decimal total = Total;
                string orderNo = _saleRepo.Checkout(AuthService.CurrentUser.Id, _cart, pay);

                MessageBox.Show(
                    $"結帳完成！\n\n單號：{orderNo}\n應收：$ {total:N0}\n實收：$ {pay:N0}\n找零：$ {pay - total:N0}",
                    "結帳成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cart.Clear();
                numPay.Value = 0;
                LoadProducts();   // 庫存已變動，重新載入
                RefreshCart();
                txtBarcode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("結帳失敗：" + ex.Message, "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- 商品搜尋 ----

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadProducts();
    }
}
