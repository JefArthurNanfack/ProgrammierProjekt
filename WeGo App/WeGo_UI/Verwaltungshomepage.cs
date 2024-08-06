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
    public partial class Verwaltungshomepage : Form
    {
        public Verwaltungshomepage()
        {
            InitializeComponent();
        }

        private void KMBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kundenmanagement kn = new Kundenmanagement();
            kn.Show();
        }

        private void KELBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EveneLeiteung el = new EveneLeiteung();
            el.Show();  
        }

        private void ÜWBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Überwachung üw = new Überwachung();
            üw.Show();
        }

        private void SLBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SupportLeisten support = new SupportLeisten();
            //support.Show();
        }

        private void Verwaltungshomepage_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
