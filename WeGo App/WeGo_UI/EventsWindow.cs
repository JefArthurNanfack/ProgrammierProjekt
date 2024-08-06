using Microsoft.Data.SqlClient;
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
    public partial class EventsWindow : Form
    {
        public EventsWindow()
        {
            InitializeComponent();
        }


       

        private void EventsWindow_Load(object sender, EventArgs e)
        {
            LoadData();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1100, h - 500);
        }

        private void EventsBx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string C = "server = localhost; uid = root; pwd= 123456789wego; database = mydb";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = C;
            

            try
            {
                // Verbindung öffnen
                conn.Open();

                // SQL-Abfrage ausführen
                string query = "SELECT Event_name, Datum, Uhrzeit FROM events ORDER BY Datum, Uhrzeit";

                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

                // RichTextBox leeren
                EventsBx.Clear();

                // Überschrift hinzufügen
                EventsBx.AppendText("\tEvent_name\tDatum\tUhrzeit\n");
                EventsBx.AppendText("--------------------------------------------------\n");

                // Daten lesen und in der RichTextBox anzeigen
                while (reader.Read())
                {
                    EventsBx.AppendText($"\t{reader["Event_name"]}\t{reader["Datum"]}\t{reader["Uhrzeit"]}\n");
                }

                // Reader schließen
                reader.Close();
            }
            catch (Exception ex)
            {
                // Fehlermeldung anzeigen
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Verbindung schließen
                conn.Close();
            }
        }
    }
}
