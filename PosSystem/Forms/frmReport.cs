using System.Drawing;
using System.Windows.Forms;

namespace PosSystem.Forms
{
    /// <summary>營收報表（佔位版，將於後續里程碑完整實作）。</summary>
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            var lbl = new Label
            {
                Text = "營收報表（建構中…）",
                Font = new Font("Microsoft JhengHei UI", 16F),
                ForeColor = Color.Gray,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lbl);
            this.BackColor = Color.White;
            this.ClientSize = new Size(820, 560);
            this.Font = new Font("Microsoft JhengHei UI", 10.5F);
            this.Name = "frmReport";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "營收報表";
            this.ResumeLayout(false);
        }
    }
}
