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
    public partial class KundenHomepage : Form
    {
        public KundenHomepage()
        {
            InitializeComponent();
        }

        private void KundenHomepage_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1120, h - 100);
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            //Events Button

            EventsWindow secondWindow = new EventsWindow();
            //this.Hide();
            secondWindow.Show();
        }


        private void WPEBtn_Click(object sender, EventArgs e)
        {
            WorkoutWindow secondWindow = new WorkoutWindow();
            //this.Hide();
            secondWindow.Show();

        }

        private void EEBtn_Click(object sender, EventArgs e)
        {
            ErnährungWindow secondWindow = new ErnährungWindow();
            //this.Hide();
            secondWindow.Show();
        }

        private void KBtn_Click(object sender, EventArgs e)
        {
            KurseWindow secondWindow = new KurseWindow();
            //this.Hide();
            secondWindow.Show();
        }

        private void SBtn_Click(object sender, EventArgs e)
        {
            SupportWindow secondWindow = new SupportWindow();
            //this.Hide();
            secondWindow.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
