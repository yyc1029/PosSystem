using System.Drawing;
using System.Windows.Forms;

namespace PosSystem.Forms
{
    /// <summary>POS 結帳（佔位版，將於後續里程碑完整實作）。</summary>
    public partial class frmPos : Form
    {
        public frmPos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            var lbl = new Label
            {
                Text = "POS 結帳（建構中…）",
                Font = new Font("Microsoft JhengHei UI", 16F),
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
            this.BackColor = Color.White;
            this.ClientSize = new Size(900, 560);
            this.Font = new Font("Microsoft JhengHei UI", 10.5F);
            this.Name = "frmPos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "POS 結帳";
            this.ResumeLayout(false);
        }
    }
}
