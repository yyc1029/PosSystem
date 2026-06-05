namespace PosSystem.Forms
{
    partial class frmPos
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPick = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblPick = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.numPay = new System.Windows.Forms.NumericUpDown();
            this.lblPayLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlPick.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPay)).BeginInit();
            this.SuspendLayout();
            //
            // pnlLeft
            //
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.dgvProducts);
            this.pnlLeft.Controls.Add(this.pnlPick);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(460, 650);
            this.pnlLeft.TabIndex = 0;
            //
            // dgvProducts
            //
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPName, this.colPPrice, this.colPStock});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 120);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(460, 530);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            //
            // colPName
            //
            this.colPName.DataPropertyName = "Name";
            this.colPName.HeaderText = "商品名稱";
            this.colPName.Name = "colPName";
            this.colPName.ReadOnly = true;
            this.colPName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colPPrice
            //
            this.colPPrice.DataPropertyName = "Price";
            this.colPPrice.HeaderText = "售價";
            this.colPPrice.Name = "colPPrice";
            this.colPPrice.ReadOnly = true;
            this.colPPrice.Width = 90;
            //
            // colPStock
            //
            this.colPStock.DataPropertyName = "Stock";
            this.colPStock.HeaderText = "庫存";
            this.colPStock.Name = "colPStock";
            this.colPStock.ReadOnly = true;
            this.colPStock.Width = 70;
            //
            // pnlPick
            //
            this.pnlPick.Controls.Add(this.txtSearch);
            this.pnlPick.Controls.Add(this.lblSearch);
            this.pnlPick.Controls.Add(this.txtBarcode);
            this.pnlPick.Controls.Add(this.lblBarcode);
            this.pnlPick.Controls.Add(this.lblPick);
            this.pnlPick.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPick.Location = new System.Drawing.Point(0, 0);
            this.pnlPick.Name = "pnlPick";
            this.pnlPick.Size = new System.Drawing.Size(460, 120);
            this.pnlPick.TabIndex = 0;
            //
            // lblPick
            //
            this.lblPick.AutoSize = true;
            this.lblPick.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPick.ForeColor = System.Drawing.Color.FromArgb(37, 42, 58);
            this.lblPick.Location = new System.Drawing.Point(14, 10);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(260, 21);
            this.lblPick.TabIndex = 0;
            this.lblPick.Text = "選擇商品（雙擊加入購物車）";
            //
            // lblBarcode
            //
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(14, 48);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(44, 20);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "條碼";
            //
            // txtBarcode
            //
            this.txtBarcode.Location = new System.Drawing.Point(70, 44);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(250, 27);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 84);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 20);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "搜尋";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(70, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 27);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            //
            // pnlRight
            //
            this.pnlRight.Controls.Add(this.dgvCart);
            this.pnlRight.Controls.Add(this.pnlCheckout);
            this.pnlRight.Controls.Add(this.lblCartTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(460, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnlRight.Size = new System.Drawing.Size(540, 650);
            this.pnlRight.TabIndex = 1;
            //
            // lblCartTitle
            //
            this.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(37, 42, 58);
            this.lblCartTitle.Location = new System.Drawing.Point(8, 0);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblCartTitle.Size = new System.Drawing.Size(524, 40);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "🛒 購物車";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvCart
            //
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colCName, this.colCPrice, this.colCQty, this.colCSub});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(8, 40);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.Height = 32;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(524, 400);
            this.dgvCart.TabIndex = 1;
            //
            // colCName
            //
            this.colCName.DataPropertyName = "ProductName";
            this.colCName.HeaderText = "商品";
            this.colCName.Name = "colCName";
            this.colCName.ReadOnly = true;
            this.colCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colCPrice
            //
            this.colCPrice.DataPropertyName = "UnitPrice";
            this.colCPrice.HeaderText = "單價";
            this.colCPrice.Name = "colCPrice";
            this.colCPrice.ReadOnly = true;
            this.colCPrice.Width = 80;
            //
            // colCQty
            //
            this.colCQty.DataPropertyName = "Quantity";
            this.colCQty.HeaderText = "數量";
            this.colCQty.Name = "colCQty";
            this.colCQty.ReadOnly = true;
            this.colCQty.Width = 60;
            //
            // colCSub
            //
            this.colCSub.DataPropertyName = "Subtotal";
            this.colCSub.HeaderText = "小計";
            this.colCSub.Name = "colCSub";
            this.colCSub.ReadOnly = true;
            this.colCSub.Width = 100;
            //
            // pnlCheckout
            //
            this.pnlCheckout.BackColor = System.Drawing.Color.FromArgb(248, 249, 252);
            this.pnlCheckout.Controls.Add(this.btnCheckout);
            this.pnlCheckout.Controls.Add(this.lblChange);
            this.pnlCheckout.Controls.Add(this.numPay);
            this.pnlCheckout.Controls.Add(this.lblPayLabel);
            this.pnlCheckout.Controls.Add(this.lblTotal);
            this.pnlCheckout.Controls.Add(this.btnClearCart);
            this.pnlCheckout.Controls.Add(this.btnRemove);
            this.pnlCheckout.Controls.Add(this.btnPlus);
            this.pnlCheckout.Controls.Add(this.btnMinus);
            this.pnlCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckout.Location = new System.Drawing.Point(8, 440);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(524, 210);
            this.pnlCheckout.TabIndex = 2;
            //
            // btnMinus
            //
            this.btnMinus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(10, 12);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 38);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "－";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            //
            // btnPlus
            //
            this.btnPlus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(66, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 38);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "＋";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            //
            // btnRemove
            //
            this.btnRemove.Location = new System.Drawing.Point(124, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 38);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "移除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            //
            // btnClearCart
            //
            this.btnClearCart.Location = new System.Drawing.Point(220, 12);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(90, 38);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "清空";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            //
            // lblTotal
            //
            this.lblTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblTotal.Location = new System.Drawing.Point(8, 62);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(508, 42);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "總計：$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblPayLabel
            //
            this.lblPayLabel.AutoSize = true;
            this.lblPayLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.lblPayLabel.Location = new System.Drawing.Point(10, 118);
            this.lblPayLabel.Name = "lblPayLabel";
            this.lblPayLabel.Size = new System.Drawing.Size(74, 21);
            this.lblPayLabel.TabIndex = 5;
            this.lblPayLabel.Text = "實收金額";
            //
            // numPay
            //
            this.numPay.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F);
            this.numPay.Location = new System.Drawing.Point(94, 114);
            this.numPay.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            this.numPay.Name = "numPay";
            this.numPay.Size = new System.Drawing.Size(150, 31);
            this.numPay.TabIndex = 6;
            this.numPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPay.ValueChanged += new System.EventHandler(this.numPay_ValueChanged);
            //
            // lblChange
            //
            this.lblChange.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblChange.Location = new System.Drawing.Point(270, 114);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(240, 31);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "找零：$ 0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnCheckout
            //
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(10, 156);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(506, 46);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "結　帳";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            //
            // frmPos
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(940, 600);
            this.Name = "frmPos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS 結帳";
            this.Load += new System.EventHandler(this.frmPos_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlPick.ResumeLayout(false);
            this.pnlPick.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlCheckout.ResumeLayout(false);
            this.pnlCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPay)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPStock;
        private System.Windows.Forms.Panel pnlPick;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCSub;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.NumericUpDown numPay;
        private System.Windows.Forms.Label lblPayLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblCartTitle;
    }
}
