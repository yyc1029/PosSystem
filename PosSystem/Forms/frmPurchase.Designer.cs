namespace PosSystem.Forms
{
    partial class frmPurchase
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            //
            // pnlInput
            //
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnAdd);
            this.pnlInput.Controls.Add(this.numCost);
            this.pnlInput.Controls.Add(this.lblCost);
            this.pnlInput.Controls.Add(this.numQty);
            this.pnlInput.Controls.Add(this.lblQty);
            this.pnlInput.Controls.Add(this.cboProduct);
            this.pnlInput.Controls.Add(this.lblProduct);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(820, 62);
            this.pnlInput.TabIndex = 0;
            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(16, 21);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "商品";
            //
            // cboProduct
            //
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.Location = new System.Drawing.Point(62, 18);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(220, 28);
            this.cboProduct.TabIndex = 1;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(300, 21);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(44, 20);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "數量";
            //
            // numQty
            //
            this.numQty.Location = new System.Drawing.Point(346, 18);
            this.numQty.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            this.numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(80, 27);
            this.numQty.TabIndex = 3;
            this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblCost
            //
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(442, 21);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(74, 20);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "進貨單價";
            //
            // numCost
            //
            this.numCost.Location = new System.Drawing.Point(522, 18);
            this.numCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(100, 27);
            this.numCost.TabIndex = 5;
            this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 134, 222);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(640, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "加入清單";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // pnlBottom
            //
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.Controls.Add(this.btnReceive);
            this.pnlBottom.Controls.Add(this.btnClear);
            this.pnlBottom.Controls.Add(this.lblTotal);
            this.pnlBottom.Controls.Add(this.btnRemove);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 530);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(820, 70);
            this.pnlBottom.TabIndex = 2;
            //
            // btnRemove
            //
            this.btnRemove.Location = new System.Drawing.Point(16, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 40);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "移除選取";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            //
            // lblTotal
            //
            this.lblTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblTotal.Location = new System.Drawing.Point(170, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(290, 34);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "進貨總成本：$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(500, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnReceive
            //
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(610, 14);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(190, 44);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.Text = "確認入庫";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
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
                this.colName, this.colQty, this.colCost, this.colSubtotal});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 62);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.Height = 32;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(820, 468);
            this.dgvCart.TabIndex = 1;
            //
            // colName
            //
            this.colName.DataPropertyName = "ProductName";
            this.colName.HeaderText = "商品名稱";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //
            // colQty
            //
            this.colQty.DataPropertyName = "Quantity";
            this.colQty.HeaderText = "數量";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 100;
            //
            // colCost
            //
            this.colCost.DataPropertyName = "UnitCost";
            this.colCost.HeaderText = "進貨單價";
            this.colCost.Name = "colCost";
            this.colCost.ReadOnly = true;
            this.colCost.Width = 120;
            //
            // colSubtotal
            //
            this.colSubtotal.DataPropertyName = "Subtotal";
            this.colSubtotal.HeaderText = "小計";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 120;
            //
            // frmPurchase
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(820, 600);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(780, 540);
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "進貨入庫";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}
