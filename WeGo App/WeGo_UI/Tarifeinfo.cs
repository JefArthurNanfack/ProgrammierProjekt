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
    public partial class Tarifeinfo : Form
    {
        public Tarifeinfo()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Neue_Kunde nk = new Neue_Kunde();
            nk.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void goldlabel3_Click(object sender, EventArgs e)
        {

        }

        private void silberlabel2_Click(object sender, EventArgs e)
        {

        }

        private void basiclabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tarifeinfo_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1120, h - 100);
        }
    }
}
