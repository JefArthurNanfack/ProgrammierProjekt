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
    public partial class WeGo_Gym : Form
    {
        public WeGo_Gym()
        {
            InitializeComponent();
        }


        private void WeGo_Gym_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            Login secondWindow = new Login();
            this.Hide();
            secondWindow.Show();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Neue_Kunde regestrieren = new Neue_Kunde();
            regestrieren.Show();
            //this.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
