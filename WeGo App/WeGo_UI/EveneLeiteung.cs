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
    public partial class EveneLeiteung : Form
    {
        public EveneLeiteung()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Verwaltungshomepage vh = new Verwaltungshomepage();
            vh.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Id = rnd.Next();
            string Eventname = textBox1.Text;
            string Uhrzeit = textBox2.Text;

            string year = Convert.ToString(dateTimePicker1.Value.Year);
            string Month = Convert.ToString(dateTimePicker1.Value.Month);
            string Day = Convert.ToString(dateTimePicker1.Value.Day);
            string Datum = Day + "." + Month + "." + year;
            string Dauer = textBox3.Text;
            //MessageBox.Show(Datum);          This was used for debugging By Mardini, With Love

            string C = "server = localhost; uid = root; pwd= 123456789wego; database = mydb";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = C;
            conn.Open();
            try
            {

                string query = "INSERT into Events (idEvents,Event_Name, Uhrzeit,Datum) VALUES (@idEvents, @Event_Name, @Uhrzeit,@Datum)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEvents", Id);
                    cmd.Parameters.AddWithValue("@Event_Name", Eventname);
                    cmd.Parameters.AddWithValue("@Uhrzeit", Uhrzeit);
                    cmd.Parameters.AddWithValue("@Datum", Datum);

                    int B = Convert.ToInt32(cmd.ExecuteNonQuery());
                    if (B > 0)
                    {
                        MessageBox.Show("Neues Event hinzugefügt");
                    }
                    else
                    {
                        MessageBox.Show("Datenübertragung Fehlgeschlagen");
                    }
                }
            }
            catch (Exception ex)
            {
                string exe = Convert.ToString(ex);
                MessageBox.Show(exe);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Uhrzeit = textBox2.Text;
            if (Uhrzeit.Length == 5) // Länge sollte 5 sein (z.B. "12:34")
            {
                if (Uhrzeit[2] == ':') // Prüfen, ob das Zeichen an der dritten Stelle ein Doppelpunkt ist
                {
                    // Überprüfen, ob jedes Zeichen an den richtigen Stellen eine Ziffer von '0' bis '9' ist
                    if ((Uhrzeit[0] >= '0' && Uhrzeit[0] <= '9') &&
                        (Uhrzeit[1] >= '0' && Uhrzeit[1] <= '9') &&
                        (Uhrzeit[3] >= '0' && Uhrzeit[3] <= '9') &&
                        (Uhrzeit[4] >= '0' && Uhrzeit[4] <= '9'))
                    {
                        uhrZeitLabel.Text = "gültige Eingabe";
                        uhrZeitLabel.BackColor = Color.Green;
                    }
                    else
                    {
                        uhrZeitLabel.Text = "ungültige Eingabe";
                        uhrZeitLabel.BackColor = Color.Red;
                    }
                }
                else
                {
                    uhrZeitLabel.Text = "Uhrzeitformat falsch";
                    uhrZeitLabel.BackColor = Color.Red;
                }
            }
            else
            {
                uhrZeitLabel.Text = "Uhrzeitformat falsch";
                uhrZeitLabel.BackColor = Color.Red;
            }
        }

        private void EveneLeiteung_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
