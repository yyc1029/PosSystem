namespace PosSystem.Forms
{
    partial class frmReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTop.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnMonth);
            this.pnlTop.Controls.Add(this.btnToday);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Controls.Add(this.lblFrom);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(900, 56);
            this.pnlTop.TabIndex = 0;
            //
            // lblFrom
            //
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(16, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "起始";
            //
            // dtpFrom
            //
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(62, 14);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(130, 27);
            this.dtpFrom.TabIndex = 1;
            //
            // lblTo
            //
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(204, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "結束";
            //
            // dtpTo
            //
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(250, 14);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(130, 27);
            this.dtpTo.TabIndex = 3;
            //
            // btnQuery
            //
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(396, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(90, 32);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            //
            // btnToday
            //
            this.btnToday.Location = new System.Drawing.Point(500, 13);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(80, 32);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "本日";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            //
            // btnMonth
            //
            this.btnMonth.Location = new System.Drawing.Point(586, 13);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(80, 32);
            this.btnMonth.TabIndex = 6;
            this.btnMonth.Text = "本月";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            //
            // pnlSummary
            //
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlSummary.Controls.Add(this.lblItems);
            this.pnlSummary.Controls.Add(this.lblOrders);
            this.pnlSummary.Controls.Add(this.lblRevenue);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Location = new System.Drawing.Point(0, 56);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlSummary.Size = new System.Drawing.Size(900, 90);
            this.pnlSummary.TabIndex = 1;
            //
            // lblRevenue
            //
            this.lblRevenue.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(16, 12);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(280, 66);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "總營收\n$ 0";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblOrders
            //
            this.lblOrders.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.lblOrders.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.White;
            this.lblOrders.Location = new System.Drawing.Point(310, 12);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(280, 66);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "訂單數\n0 筆";
            this.lblOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblItems
            //
            this.lblItems.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.lblItems.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblItems.ForeColor = System.Drawing.Color.White;
            this.lblItems.Location = new System.Drawing.Point(604, 12);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(280, 66);
            this.lblItems.TabIndex = 2;
            this.lblItems.Text = "銷售件數\n0 件";
            this.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // splitMain
            //
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 146);
            this.splitMain.Name = "splitMain";
            //
            // splitMain.Panel1
            //
            this.splitMain.Panel1.Controls.Add(this.chartRevenue);
            //
            // splitMain.Panel2
            //
            this.splitMain.Panel2.Controls.Add(this.chartTop);
            this.splitMain.Size = new System.Drawing.Size(900, 454);
            this.splitMain.SplitterDistance = 500;
            this.splitMain.TabIndex = 2;
            //
            // chartRevenue
            //
            chartArea1.Name = "AreaRevenue";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRevenue.Location = new System.Drawing.Point(0, 0);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "AreaRevenue";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(39, 174, 96);
            series1.IsValueShownAsLabel = true;
            series1.Name = "營收";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(500, 454);
            this.chartRevenue.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "titleRevenue";
            title1.Text = "每日營收";
            this.chartRevenue.Titles.Add(title1);
            //
            // chartTop
            //
            chartArea2.Name = "AreaTop";
            this.chartTop.ChartAreas.Add(chartArea2);
            this.chartTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTop.Location = new System.Drawing.Point(0, 0);
            this.chartTop.Name = "chartTop";
            this.chartTop.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("LegendTop"));
            series2.ChartArea = "AreaTop";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "LegendTop";
            series2.Name = "熱銷";
            this.chartTop.Series.Add(series2);
            this.chartTop.Size = new System.Drawing.Size(396, 454);
            this.chartTop.TabIndex = 0;
            title2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "titleTop";
            title2.Text = "熱銷商品 TOP 5（銷售數量）";
            this.chartTop.Titles.Add(title2);
            //
            // frmReport
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(840, 560);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "營收報表";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop;
    }
}
