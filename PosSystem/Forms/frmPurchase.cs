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
    /// 進貨入庫：選擇商品、數量與進貨單價加入清單，確認後一次寫入進貨單並增加庫存。
    /// </summary>
    public partial class frmPurchase : Form
    {
        private readonly ProductRepository _productRepo = new ProductRepository();
        private readonly PurchaseRepository _purchaseRepo = new PurchaseRepository();
        private readonly List<PurchaseItem> _cart = new List<PurchaseItem>();

        // 由低庫存清單跳轉而來時，預先選好的商品 Id（0 表示不指定）
        private readonly int _preselectId;

        public frmPurchase()
        {
            InitializeComponent();
        }

        /// <summary>從低庫存「前往補貨」跳轉時使用，自動選好該商品。</summary>
        public frmPurchase(int preselectProductId) : this()
        {
            _preselectId = preselectProductId;
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RefreshCart();

            // 自動選好指定商品並把游標移到「數量」，店員只要輸入數量即可入庫
            if (_preselectId > 0)
            {
                cboProduct.SelectedValue = _preselectId;
                numQty.Focus();
                numQty.Select(0, numQty.Text.Length);
            }
        }

        private void LoadProducts()
        {
            cboProduct.DataSource = _productRepo.GetAll();
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "Id";
        }

        // 切換商品時，進貨單價預設帶入該商品目前成本
        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedItem is Product p)
                numCost.Value = Math.Min(p.Cost, numCost.Maximum);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(cboProduct.SelectedItem is Product p))
            {
                MessageBox.Show("請先選擇商品。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int qty = (int)numQty.Value;
            decimal cost = numCost.Value;

            var existing = _cart.FirstOrDefault(i => i.ProductId == p.Id);
            if (existing != null)
            {
                existing.Quantity += qty;
                existing.UnitCost = cost;
            }
            else
            {
                _cart.Add(new PurchaseItem
                {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    Quantity = qty,
                    UnitCost = cost
                });
            }
            RefreshCart();
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _cart.ToList();
            decimal total = _cart.Sum(i => i.Subtotal);
            lblTotal.Text = $"進貨總成本：$ {total:N0}";
            btnReceive.Enabled = _cart.Count > 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow?.DataBoundItem is PurchaseItem item)
            {
                _cart.RemoveAll(i => i.ProductId == item.ProductId);
                RefreshCart();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            try
            {
                string orderNo = _purchaseRepo.Receive(AuthService.CurrentUser.Id, _cart);
                MessageBox.Show($"進貨完成！\n進貨單號：{orderNo}\n庫存已更新。", "入庫成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _cart.Clear();
                RefreshCart();
                LoadProducts();   // 重新載入以反映最新庫存/成本
            }
            catch (Exception ex)
            {
                MessageBox.Show("入庫失敗：" + ex.Message, "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
