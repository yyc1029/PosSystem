namespace PosSystem.Forms
{
    partial class frmMain
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.lblLowStockHint = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();
            //
            // pnlSide
            //
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(37, 42, 58);
            this.pnlSide.Controls.Add(this.lblTitle);
            this.pnlSide.Controls.Add(this.btnPos);
            this.pnlSide.Controls.Add(this.btnProduct);
            this.pnlSide.Controls.Add(this.btnPurchase);
            this.pnlSide.Controls.Add(this.btnInventory);
            this.pnlSide.Controls.Add(this.btnReport);
            this.pnlSide.Controls.Add(this.btnEmployee);
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(210, 620);
            this.pnlSide.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 POS 進銷存";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnPos
            //
            this.StyleNavButton(this.btnPos, 100, "    🧾   POS 結帳");
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            //
            // btnProduct
            //
            this.StyleNavButton(this.btnProduct, 152, "    📦   商品管理");
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            //
            // btnPurchase
            //
            this.StyleNavButton(this.btnPurchase, 204, "    🚚   進貨入庫");
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            //
            // btnInventory
            //
            this.StyleNavButton(this.btnInventory, 256, "    📊   庫存查詢");
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            //
            // btnReport
            //
            this.StyleNavButton(this.btnReport, 308, "    📈   營收報表");
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            //
            // btnEmployee
            //
            this.StyleNavButton(this.btnEmployee, 360, "    👤   員工管理");
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            //
            // btnLogout
            //
            this.StyleNavButton(this.btnLogout, 555, "    ⏏   登出");
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // lblWelcome
            //
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(37, 42, 58);
            this.lblWelcome.Location = new System.Drawing.Point(232, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "歡迎";
            //
            // lblDateTime
            //
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F);
            this.lblDateTime.ForeColor = System.Drawing.Color.Gray;
            this.lblDateTime.Location = new System.Drawing.Point(234, 68);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(60, 20);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "日期";
            //
            // btnExport
            //
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(686, 30);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(110, 42);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "📤 匯出資料";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            //
            // btnImport
            //
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(804, 30);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 42);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "📥 匯入資料";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            //
            // lblLowStockTitle
            //
            this.lblLowStockTitle.AutoSize = true;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLowStockTitle.Location = new System.Drawing.Point(234, 120);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(90, 21);
            this.lblLowStockTitle.TabIndex = 3;
            this.lblLowStockTitle.Text = "低庫存警示";
            //
            // lblLowStockHint
            //
            this.lblLowStockHint.AutoSize = true;
            this.lblLowStockHint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.5F);
            this.lblLowStockHint.ForeColor = System.Drawing.Color.Gray;
            this.lblLowStockHint.Location = new System.Drawing.Point(236, 150);
            this.lblLowStockHint.Name = "lblLowStockHint";
            this.lblLowStockHint.Size = new System.Drawing.Size(90, 18);
            this.lblLowStockHint.TabIndex = 5;
            this.lblLowStockHint.Text = "💡 點該列的「前往補貨」按鈕，或雙擊該列，即可快速進貨補充庫存";
            //
            // dgvLowStock
            //
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            this.dgvLowStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colName, this.colStock, this.colSafety, this.colAction});
            this.dgvLowStock.Location = new System.Drawing.Point(234, 178);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowTemplate.Height = 30;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(680, 412);
            this.dgvLowStock.TabIndex = 4;
            this.dgvLowStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLowStock_CellContentClick);
            this.dgvLowStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLowStock_CellDoubleClick);
            //
            // colName
            //
            this.colName.HeaderText = "商品名稱";
            this.colName.Name = "colName";
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colStock
            //
            this.colStock.HeaderText = "現有庫存";
            this.colStock.Name = "colStock";
            this.colStock.Width = 120;
            //
            // colSafety
            //
            this.colSafety.HeaderText = "安全庫存";
            this.colSafety.Name = "colSafety";
            this.colSafety.Width = 120;
            //
            // colAction
            //
            this.colAction.HeaderText = "操作";
            this.colAction.Name = "colAction";
            this.colAction.Text = "前往補貨";
            this.colAction.UseColumnTextForButtonValue = true;
            this.colAction.Width = 130;
            this.colAction.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            //
            // frmMain
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(940, 620);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.lblLowStockHint);
            this.Controls.Add(this.lblLowStockTitle);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlSide);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(820, 560);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS 進銷存系統";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>套用導覽按鈕共用樣式（扁平、白字、靠左）。</summary>
        private void StyleNavButton(System.Windows.Forms.Button btn, int top, string text)
        {
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 60, 80);
            btn.BackColor = System.Drawing.Color.FromArgb(37, 42, 58);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(0, top);
            btn.Size = new System.Drawing.Size(210, 48);
            btn.Text = text;
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblLowStockHint;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSafety;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
