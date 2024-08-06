using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dapper;

namespace WeGo_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("server = localhost; uid = root; pwd= 123456789wego; database = mydb");
            con.Open();
            string query = "SELECT COUNT(*) FROM kunde WHERE Name = @Name AND Password = @Password  ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (textBox1.Text == "Admin" & textBox2.Text == "123456789")
            {
                Verwaltungshomepage secondwendow = new Verwaltungshomepage();
                secondwendow.Show();
                this.Close();
            }
            else if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KundenHomepage SecondWindow = new KundenHomepage();
                SecondWindow.Show();
            }
            else
            {
                MessageBox.Show("Es gibt einen Fehler bei dem Benutzername oder Passwort");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void BtnRücksetz_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
