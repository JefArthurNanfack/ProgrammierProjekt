using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeGo_UI
{
    public partial class StretchWinform : Form
    {
        public StretchWinform()
        {
            InitializeComponent();
        }

        private void BtnReturnStretch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StretchWinform_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 700, h - 300);
        }
    }
}
