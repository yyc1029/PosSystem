using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PosSystem.Data;
using PosSystem.Models;

namespace PosSystem.Forms
{
    /// <summary>
    /// 庫存查詢（唯讀檢視）：列出所有商品的庫存狀況，支援搜尋與「只看低庫存」，
    /// 低於安全庫存的商品以紅字標示。管理員與收銀員皆可使用。
    /// </summary>
    public partial class frmInventory : Form
    {
        private readonly ProductRepository _repo = new ProductRepository();

        public frmInventory()
        {
            InitializeComponent();
        }

        private void frmInventory_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            List<Product> list = _repo.GetAll(txtSearch.Text.Trim());
            if (chkLowOnly.Checked)
                list = list.Where(p => p.IsLowStock).ToList();

            dgvStock.DataSource = null;
            dgvStock.DataSource = list;

            int lowCount = 0;
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.DataBoundItem is Product p)
                {
                    row.Cells["colStatus"].Value = p.IsLowStock ? "⚠ 低庫存" : "足夠";
                    if (p.IsLowStock)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Firebrick;
                        lowCount++;
                    }
                }
            }

            lblSummary.Text = $"共 {list.Count} 項商品，其中 {lowCount} 項需要補貨";
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadData();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            chkLowOnly.Checked = false;
            LoadData();
        }

        private void chkLowOnly_CheckedChanged(object sender, EventArgs e) => LoadData();
    }
}
