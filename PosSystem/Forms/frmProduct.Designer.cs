namespace PosSystem.Forms
{
    partial class frmProduct
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.numSafety = new System.Windows.Forms.NumericUpDown();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblSafety = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSafety = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlTop.SuspendLayout();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSafety)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(940, 56);
            this.pnlTop.TabIndex = 0;
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "搜尋";
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(66, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 27);
            this.txtSearch.TabIndex = 1;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(316, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(406, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "重新整理";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // grpEdit
            //
            this.grpEdit.Controls.Add(this.btnDelete);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnNew);
            this.grpEdit.Controls.Add(this.lblMode);
            this.grpEdit.Controls.Add(this.chkActive);
            this.grpEdit.Controls.Add(this.numSafety);
            this.grpEdit.Controls.Add(this.numStock);
            this.grpEdit.Controls.Add(this.numCost);
            this.grpEdit.Controls.Add(this.numPrice);
            this.grpEdit.Controls.Add(this.cboCategory);
            this.grpEdit.Controls.Add(this.txtName);
            this.grpEdit.Controls.Add(this.txtBarcode);
            this.grpEdit.Controls.Add(this.lblSafety);
            this.grpEdit.Controls.Add(this.lblStock);
            this.grpEdit.Controls.Add(this.lblCost);
            this.grpEdit.Controls.Add(this.lblPrice);
            this.grpEdit.Controls.Add(this.lblCategory);
            this.grpEdit.Controls.Add(this.lblName);
            this.grpEdit.Controls.Add(this.lblBarcode);
            this.grpEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpEdit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpEdit.Location = new System.Drawing.Point(600, 56);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(340, 544);
            this.grpEdit.TabIndex = 2;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "商品資料";
            //
            // lblBarcode
            //
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblBarcode.Location = new System.Drawing.Point(20, 45);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(44, 19);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "條碼";
            //
            // txtBarcode
            //
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.txtBarcode.Location = new System.Drawing.Point(120, 42);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 27);
            this.txtBarcode.TabIndex = 1;
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblName.Location = new System.Drawing.Point(20, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "商品名稱";
            //
            // txtName
            //
            this.txtName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.txtName.Location = new System.Drawing.Point(120, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 3;
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblCategory.Location = new System.Drawing.Point(20, 129);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(44, 19);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "分類";
            //
            // cboCategory
            //
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.cboCategory.Location = new System.Drawing.Point(120, 126);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(200, 28);
            this.cboCategory.TabIndex = 5;
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblPrice.Location = new System.Drawing.Point(20, 171);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 19);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "售價";
            //
            // numPrice
            //
            this.numPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.numPrice.Location = new System.Drawing.Point(120, 168);
            this.numPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 27);
            this.numPrice.TabIndex = 7;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblCost
            //
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblCost.Location = new System.Drawing.Point(20, 213);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(44, 19);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "成本";
            //
            // numCost
            //
            this.numCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.numCost.Location = new System.Drawing.Point(120, 210);
            this.numCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(200, 27);
            this.numCost.TabIndex = 9;
            this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblStock
            //
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblStock.Location = new System.Drawing.Point(20, 255);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(74, 19);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "現有庫存";
            //
            // numStock
            //
            this.numStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.numStock.Location = new System.Drawing.Point(120, 252);
            this.numStock.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(200, 27);
            this.numStock.TabIndex = 11;
            this.numStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSafety
            //
            this.lblSafety.AutoSize = true;
            this.lblSafety.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblSafety.Location = new System.Drawing.Point(20, 297);
            this.lblSafety.Name = "lblSafety";
            this.lblSafety.Size = new System.Drawing.Size(74, 19);
            this.lblSafety.TabIndex = 12;
            this.lblSafety.Text = "安全庫存";
            //
            // numSafety
            //
            this.numSafety.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.numSafety.Location = new System.Drawing.Point(120, 294);
            this.numSafety.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numSafety.Name = "numSafety";
            this.numSafety.Size = new System.Drawing.Size(200, 27);
            this.numSafety.TabIndex = 13;
            this.numSafety.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // chkActive
            //
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.chkActive.Location = new System.Drawing.Point(120, 334);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(105, 23);
            this.chkActive.TabIndex = 14;
            this.chkActive.Text = "上架販售";
            this.chkActive.UseVisualStyleBackColor = true;
            //
            // lblMode
            //
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMode.Location = new System.Drawing.Point(20, 375);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(74, 19);
            this.lblMode.TabIndex = 15;
            this.lblMode.Text = "新增模式";
            //
            // btnNew
            //
            this.btnNew.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.btnNew.Location = new System.Drawing.Point(20, 410);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 44);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "清空";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(122, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 44);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnDelete
            //
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(224, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
                this.colBarcode, this.colName, this.colCategory, this.colPrice,
                this.colCost, this.colStock, this.colSafety, this.colActive});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 56);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(600, 544);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            //
            // colBarcode
            //
            this.colBarcode.DataPropertyName = "Barcode";
            this.colBarcode.HeaderText = "條碼";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.Width = 130;
            //
            // colName
            //
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "商品名稱";
            this.colName.Name = "colName";
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colCategory
            //
            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.HeaderText = "分類";
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 80;
            //
            // colPrice
            //
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "售價";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 70;
            //
            // colCost
            //
            this.colCost.DataPropertyName = "Cost";
            this.colCost.HeaderText = "成本";
            this.colCost.Name = "colCost";
            this.colCost.Width = 70;
            //
            // colStock
            //
            this.colStock.DataPropertyName = "Stock";
            this.colStock.HeaderText = "庫存";
            this.colStock.Name = "colStock";
            this.colStock.Width = 60;
            //
            // colSafety
            //
            this.colSafety.DataPropertyName = "SafetyStock";
            this.colSafety.HeaderText = "安全量";
            this.colSafety.Name = "colSafety";
            this.colSafety.Width = 70;
            //
            // colActive
            //
            this.colActive.DataPropertyName = "IsActive";
            this.colActive.HeaderText = "上架";
            this.colActive.Name = "colActive";
            this.colActive.Width = 50;
            //
            // frmProduct
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(940, 600);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(880, 560);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSafety)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.NumericUpDown numSafety;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblSafety;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSafety;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
    }
}
