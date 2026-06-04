using System.Drawing;
using System.Windows.Forms;

namespace PosSystem.Forms
{
    /// <summary>庫存查詢（佔位版，將於後續里程碑完整實作）。</summary>
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            var lbl = new Label
            {
                Text = "庫存查詢（建構中…）",
                Font = new Font("Microsoft JhengHei UI", 16F),
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
            this.BackColor = Color.White;
            this.ClientSize = new Size(700, 460);
            this.Font = new Font("Microsoft JhengHei UI", 10.5F);
            this.Name = "frmInventory";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "庫存查詢";
            this.ResumeLayout(false);
        }
    }
}
