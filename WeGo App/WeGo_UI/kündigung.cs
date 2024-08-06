using MySql.Data.MySqlClient;
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
    public partial class kündigung : Form
    {
        public kündigung()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Kundenmanagement km = new Kundenmanagement();
            km.Show();
            this.Close();
        }

        private void kdbtn_Click(object sender, EventArgs e)
        {
            string kundenId = textBox1.Text;
            string C = "server = localhost; uid = root; pwd= 123456789wego; database = mydb";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = C;
            conn.Open();
            try
            {

                string query = "DELETE FROM kunde WHERE idKunde = @idKunde;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@idKunde", kundenId);

                    int B = cmd.ExecuteNonQuery();
                    if (B > 0)
                    {
                        MessageBox.Show("Diese Kunde wurde gekündigt");
                    }
                    else
                    {
                        MessageBox.Show("Fehlgeschlagen bei der Kündigung");
                    }
                }
            }
            catch (Exception ex)
            {
                string exe = Convert.ToString(ex);
                MessageBox.Show(exe);
            }
        }

        private void kdlabel_Click(object sender, EventArgs e)
        {

        }

        private void kündigung_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1250, h - 100);
        }
    }
}
