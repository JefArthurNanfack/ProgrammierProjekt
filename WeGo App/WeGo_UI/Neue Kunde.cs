using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Numerics;
using Dapper;
using MySql;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using MySql.Data;
using static WeGo_UI.AddressValidator;
using Microsoft.Data.SqlClient;
using MySql.Simple;

namespace WeGo_UI
{
    public partial class Neue_Kunde : Form
    {

        public Neue_Kunde()
        {
            InitializeComponent();
            /*nachBox.TextChanged += new EventHandler(nachBox_TextChanged);
            nmbox.TextChanged += new EventHandler(nmbox_TextChanged);
            emBox.TextChanged += new EventHandler(emBox_TextChanged);
            nrBox.TextChanged += new EventHandler(nrBox_TextChanged);
            PassBox.TextChanged += new EventHandler(textBox1_TextChanged);*/
            //The previous shit was used for an expirement by mardini, with love.

        }




        private void wtbtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Id = rnd.Next();
            string Kname = $"{nmbox.Text} {nachBox.Text}";
            string email = emBox.Text;
            string Tele = nrBox.Text;
            string password = PassBox.Text;
            //MessageBox.Show(Kname);     This was used for debugging By Mardini, With Love

            string C = "server = localhost; uid = root; pwd= 123456789wego; database = mydb";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = C;
            conn.Open();


            try
            {

                string query = "INSERT into kunde (idKunde,Name,Email,TeleNummer,Password) VALUES (@idKunde,@Name,@Email,@TeleNummer,@Password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idKunde", Id);
                    cmd.Parameters.AddWithValue("@Name", Kname);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TeleNummer", Tele);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int B = cmd.ExecuteNonQuery();
                    Login Secondwindow = new Login();
                    this.Close();
                    Secondwindow.Show();
                    if (B > 0)
                    {
                        MessageBox.Show($"Welcome to WeGo{Kname}");
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

        private void Nklabel_TextChanged(object sender, EventArgs e)
        {

        }


        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Kundenmanagement km = new Kundenmanagement();
            km.Show();
            this.Hide();


        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            Tarifeinfo ti = new Tarifeinfo();
            ti.Show();
            this.Close();
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Neue_Kunde_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Stadt_Label_Click(object sender, EventArgs e)
        {

        }

        private void PLZ_Label_Click(object sender, EventArgs e)
        {

        }
        private void StartStraßenüberprüfung()
        {
            string street = Straße_TextBox.Text;
            string houseNumber = textBox3.Text;
            string postalCode = textBox4.Text;
            string city = textBox5.Text;

            if (!string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(houseNumber) &&
                !string.IsNullOrEmpty(postalCode) && !string.IsNullOrEmpty(city))
            {
                bool isValidAddress = AddressValidator.IsAddressValid(street, houseNumber, postalCode, city);

                if (isValidAddress)
                {
                    Straße_Label2.Text = "Die eingegebene Adresse ist gültig.";
                    Straße_Label2.ForeColor = Color.Green;
                }
                else
                {
                    Straße_Label2.Text = "Die eingegebene Adresse ist nicht gültig.";
                    Straße_Label2.ForeColor = Color.Red;
                }
            }
            else
            {
                Straße_Label2.Text = "Bitte geben Sie alle Adressfelder ein.";
                Straße_Label2.ForeColor = Color.Black;
            }
        }
        private void StartIbanÜberprüfung()
        {
            string iban = textBox2.Text; // Assuming textBox2 is the input for IBAN

            // Überprüfen Sie, ob die IBAN mindestens 2 Zeichen lang ist
            if (iban.Length < 2)
            {
                label10.ForeColor = Color.Red;
                label10.Text = "IBAN zu kurz.";
                return;
            }

            if (IbanValidator.IsValidIban(iban))
            {
                label10.ForeColor = Color.Green;
                label10.Text = "Die IBAN ist gültig.";
            }
            else
            {
                label10.ForeColor = Color.Red;
                label10.Text = "Die IBAN ist ungültig.";
            }
        }
        private void Straße_TextBox_TextChanged(object sender, EventArgs e)
        {
            StartStraßenüberprüfung();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string stadt = textBox5.Text;
            if (stadt == "Berlin")
            {
                label3.ForeColor = Color.Green;
                label3.Text = "gültige Stadt";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "ungültige Stadt";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            StartIbanÜberprüfung();

        }

        private void emBox_TextChanged(object sender, EventArgs e)
        {
            StartEmailÜberprüfung();
        }
        private void StartEmailÜberprüfung()
        {
            string email = emBox.Text;

            if (IsValidEmail(email))
            {
                label7.ForeColor = Color.Green;
                label7.Text = "Die E-Mail ist gültig.";
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Die E-Mail ist ungültig.";
            }
        }
        private bool IsValidEmail(string email)
        {

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nrBox_TextChanged(object sender, EventArgs e)
        {
            StartPhoneNumberÜberprüfung();


        }
        private void StartPhoneNumberÜberprüfung()
        {
            string phoneNumber = nrBox.Text;

            if (IsValidGermanPhoneNumber(phoneNumber))
            {
                label8.ForeColor = Color.Green;
                label8.Text = "Die Telefonnummer ist gültig.";
            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Die Telefonnummer ist ungültig.";
            }
        }
        private bool IsValidGermanPhoneNumber(string phoneNumber)
        {
            // Überprüfung für deutsche Handynummern
            return Regex.IsMatch(phoneNumber,
                @"^(?:\+49|0)\s?1[5-7]\d{1}\s?\d{7,9}$",
                RegexOptions.IgnoreCase);
        }

        private void nachBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmbox_TextChanged(object sender, EventArgs e)
        {


        }

        private void gbTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nhlabel_Click(object sender, EventArgs e)
        {

        }

        private void Gblabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class AddressValidator
    {
        public static bool IsAddressValid(string street, string houseNumber, string postalCode, string city)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(houseNumber) ||
                string.IsNullOrWhiteSpace(postalCode) || string.IsNullOrWhiteSpace(city))
            {
                return false;
            }

            // Check if house number contains only digits
            if (!Regex.IsMatch(houseNumber, @"^\d+$"))
            {
                return false;
            }

            // Check if postal code contains exactly 5 digits
            if (!Regex.IsMatch(postalCode, @"^\d{5}$"))
            {
                return false;
            }

            // Check if city contains only letters, spaces, and German umlauts
            if (!Regex.IsMatch(city, @"^[a-zA-ZäöüßÄÖÜ\s]+$"))
            {
                return false;
            }

            return true;
        }
        public class IbanValidator
        {
            public static bool IsValidIban(string iban)
            {
                iban = iban.Replace(" ", string.Empty).ToUpper();

                // Überprüfen Sie, ob die IBAN mindestens 2 Zeichen lang ist
                if (iban.Length < 2)
                {
                    return false;
                }

                if (!IsValidLength(iban))
                    return false;

                string rearrangedIban = iban.Substring(4) + iban.Substring(0, 4);
                string numericIban = ConvertToNumeric(rearrangedIban);

                return IsValidChecksum(numericIban);
            }

            private static bool IsValidLength(string iban)
            {
                var ibanLengths = new Dictionary<string, int>
        {
            { "DE", 22 },
            { "FR", 27 },
            { "GB", 22 },
            { "NL", 18 }
            // Weitere Länder und deren IBAN-Längen hinzufügen
        };

                string countryCode = iban.Substring(0, 2);

                if (ibanLengths.TryGetValue(countryCode, out int expectedLength))
                {
                    return iban.Length == expectedLength;
                }

                return false;
            }

            private static string ConvertToNumeric(string rearrangedIban)
            {
                string numericIban = string.Empty;

                foreach (char c in rearrangedIban)
                {
                    if (char.IsLetter(c))
                    {
                        numericIban += (c - 'A' + 10).ToString();
                    }
                    else
                    {
                        numericIban += c;
                    }
                }

                return numericIban;
            }

            private static bool IsValidChecksum(string numericIban)
            {
                BigInteger ibanNumber = BigInteger.Parse(numericIban);
                return ibanNumber % 97 == 1;
            }
        }
    }
}