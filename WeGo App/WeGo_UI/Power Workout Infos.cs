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
    public partial class PowerWinForm : Form
    {
        public PowerWinForm()
        {
            InitializeComponent();
        }

        private void BtnReturnPower_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PowerWinForm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 783, h - 250);
        }
    }
}
