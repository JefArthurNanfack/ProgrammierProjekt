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
    public partial class ProfilBearbeitenWindow : Form
    {
        public ProfilBearbeitenWindow()
        {
            InitializeComponent();
        }

        private void ProfilBearbeitenWindow_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1000, h - 500);
        }

        private void AÄBtn_Click(object sender, EventArgs e)
        {
            AboÄndern secondWindow = new AboÄndern();
            //this.Hide();
            secondWindow.Show();
        }

        private void VKBtn_Click(object sender, EventArgs e)
        {

        }

        private void GoldBnt_Click(object sender, EventArgs e)
        {

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {

        }

        private void BasBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
