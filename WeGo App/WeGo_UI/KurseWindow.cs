using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace WeGo_UI
{
    public partial class KurseWindow : Form
    {
        private string connectionString = "server = localhost; uid = root; pwd= 123456789wego; database = mydb";

        public KurseWindow()
        {
            InitializeComponent();


        }
        /* string Select = "";
         string Select1 = "";
         string Select2 = "";
         string Select3 = "";
         string Select4 = "";*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DateLb_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Ftrbtn_Click(object sender, EventArgs e)
        {
            FtnTrn secondWindow = new FtnTrn();
            //this.Hide();
            secondWindow.Show();
        }

        private void BtnAnmelden_Click(object sender, EventArgs e)
        {

            CBoxAerobic.Checked = false;
            CBoxFit.Checked = false;
            CBoxFuntional.Checked = false;
            CBoxPower.Checked = false;
            CBoxRückenfit.Checked = false;
            CBoxStretch.Checked = false;
            MessageBox.Show("Courses added seccessfully");



        }
        private void SaveCheckboxStateToDatabase(bool checkboxState)
        {

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StretchWinform secondWindow = new StretchWinform();
            //this.Hide();
            secondWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PowerWinForm secondWindow = new PowerWinForm();
            //this.Hide();
            secondWindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FitWinForm secondWindow = new FitWinForm();
            //this.Hide();
            secondWindow.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {

            AerobicWinForm secondWindow = new AerobicWinForm();
            //this.Hide();
            secondWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RückenfitWinform secondWindow = new RückenfitWinform();
            //this.Hide();
            secondWindow.Show();
        }

        private void KurseWindow_Load(object sender, EventArgs e)
        {

        }

        private void BtnAbmelden_Click(object sender, EventArgs e)
        {
            CBoxFuntional.Checked = false;
            CBoxStretch.Checked = false;
            CBoxFit.Checked = false;
            CBoxPower.Checked = false;
            CBoxAerobic.Checked = false;
            CBoxRückenfit.Checked = false;
            MessageBox.Show("Abmeldung erfolgreich !");
        }

        private void BtnAbmelden_Click_1(object sender, EventArgs e)
        {
            CBoxAerobic.Checked = false;
            CBoxFit.Checked = false;
            CBoxFuntional.Checked = false;
            CBoxPower.Checked = false;
            CBoxRückenfit.Checked = false;
            CBoxStretch.Checked = false;
            MessageBox.Show("Courses removed seccessfully");
        }
    }
}
