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
    public partial class Kundenmanagement : Form
    {
        public Kundenmanagement()
        {
            InitializeComponent();
        }

        private void Nkbtn_Click(object sender, EventArgs e)
        {
            Neue_Kunde NK = new Neue_Kunde();
            NK.Show();

        }

        private void Kdbtn_Click(object sender, EventArgs e)
        {
            kündigung kd = new kündigung();
            kd.Show();


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Verwaltungshomepage vh = new Verwaltungshomepage();
            vh.Show();
            this.Close();
        }

        private void Kundenmanagement_Load(object sender, EventArgs e)
        {

        }
    }
}
