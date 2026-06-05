namespace PosSystem.Forms
{
    partial class frmEmployee
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
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            //
            // grpEdit
            //
            this.grpEdit.Controls.Add(this.btnDelete);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnNew);
            this.grpEdit.Controls.Add(this.lblMode);
            this.grpEdit.Controls.Add(this.txtPassword);
            this.grpEdit.Controls.Add(this.lblPassword);
            this.grpEdit.Controls.Add(this.cboRole);
            this.grpEdit.Controls.Add(this.lblRole);
            this.grpEdit.Controls.Add(this.txtFullName);
            this.grpEdit.Controls.Add(this.lblFullName);
            this.grpEdit.Controls.Add(this.txtUsername);
            this.grpEdit.Controls.Add(this.lblUsername);
            this.grpEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpEdit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpEdit.Location = new System.Drawing.Point(520, 0);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(340, 560);
            this.grpEdit.TabIndex = 1;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "帳號資料";
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblUsername.Location = new System.Drawing.Point(20, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(44, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "帳號";
            //
            // txtUsername
            //
            this.txtUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.txtUsername.Location = new System.Drawing.Point(120, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 27);
            this.txtUsername.TabIndex = 1;
            //
            // lblFullName
            //
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblFullName.Location = new System.Drawing.Point(20, 97);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(44, 19);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "姓名";
            //
            // txtFullName
            //
            this.txtFullName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.txtFullName.Location = new System.Drawing.Point(120, 94);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 27);
            this.txtFullName.TabIndex = 3;
            //
            // lblRole
            //
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblRole.Location = new System.Drawing.Point(20, 144);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(44, 19);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "角色";
            //
            // cboRole
            //
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.cboRole.Location = new System.Drawing.Point(120, 141);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(200, 28);
            this.cboRole.TabIndex = 5;
            //
            // lblPassword
            //
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.lblPassword.Location = new System.Drawing.Point(20, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "密碼";
            //
            // txtPassword
            //
            this.txtPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.txtPassword.Location = new System.Drawing.Point(120, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(200, 27);
            this.txtPassword.TabIndex = 7;
            //
            // lblMode
            //
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblMode.Location = new System.Drawing.Point(20, 232);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(74, 18);
            this.lblMode.TabIndex = 8;
            this.lblMode.Text = "新增模式";
            //
            // btnNew
            //
            this.btnNew.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.btnNew.Location = new System.Drawing.Point(20, 270);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 44);
            this.btnNew.TabIndex = 9;
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
            this.btnSave.Location = new System.Drawing.Point(122, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 44);
            this.btnSave.TabIndex = 10;
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
            this.btnDelete.Location = new System.Drawing.Point(224, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 44);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // dgvEmployees
            //
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUsername, this.colFullName, this.colRole, this.colCreatedAt});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 30;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(520, 560);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            //
            // colUsername
            //
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "帳號";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 120;
            //
            // colFullName
            //
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "姓名";
            this.colFullName.Name = "colFullName";
            this.colFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFullName.ReadOnly = true;
            //
            // colRole
            //
            this.colRole.DataPropertyName = "RoleText";
            this.colRole.HeaderText = "角色";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 90;
            //
            // colCreatedAt
            //
            this.colCreatedAt.DataPropertyName = "CreatedAt";
            this.colCreatedAt.HeaderText = "建立時間";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            this.colCreatedAt.Width = 160;
            //
            // frmEmployee
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(860, 560);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.grpEdit);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.5F);
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "員工帳號管理";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}
