using System;
using System.Windows.Forms;
using PosSystem.Services;

namespace PosSystem.Forms
{
    /// <summary>
    /// 營收報表：依日期區間統計總營收、訂單數、銷售件數，
    /// 並以長條圖呈現每日營收、以圓餅圖呈現熱銷商品。
    /// </summary>
    public partial class frmReport : Form
    {
        private readonly ReportService _report = new ReportService();

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            Query();
        }

        private void Query()
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;
            if (from > to)
            {
                MessageBox.Show("起始日期不可晚於結束日期。", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 彙總數字
            var s = _report.GetSummary(from, to);
            lblRevenue.Text = $"總營收\n$ {s.revenue:N0}";
            lblOrders.Text = $"訂單數\n{s.orderCount} 筆";
            lblItems.Text = $"銷售件數\n{s.itemCount} 件";

            // 每日營收長條圖
            var daily = _report.GetDailyRevenue(from, to);
            var sr = chartRevenue.Series[0];
            sr.Points.Clear();
            foreach (var d in daily)
            {
                // 標籤只顯示「月-日」較精簡
                string label = d.Label.Length >= 10 ? d.Label.Substring(5) : d.Label;
                int idx = sr.Points.AddXY(label, d.Value);
                sr.Points[idx].Label = d.Value.ToString("N0");
            }

            // 熱銷商品圓餅圖
            var top = _report.GetTopProducts(from, to, 5);
            var st = chartTop.Series[0];
            st.Points.Clear();
            foreach (var t in top)
            {
                int idx = st.Points.AddXY(t.Label, t.Value);
                st.Points[idx].LegendText = t.Label;
                st.Points[idx].Label = $"{t.Value:N0}";
            }
            if (top.Count == 0)
                chartTop.Titles[0].Text = "熱銷商品（此區間尚無銷售）";
            else
                chartTop.Titles[0].Text = "熱銷商品 TOP 5（銷售數量）";
        }

        private void btnQuery_Click(object sender, EventArgs e) => Query();

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            Query();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpTo.Value = DateTime.Today;
            Query();
        }
    }
}
