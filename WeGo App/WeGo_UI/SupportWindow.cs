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
    public partial class SupportWindow : Form
    {
        public SupportWindow()
        {
            InitializeComponent();
        }

        private void SupportWindow_Load(object sender, EventArgs e)
        {
            InitializeButtons();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w - 1100, h - 100);
        }

        private void InitializeButtons()
        {
            Q1Btn.Text = "Wie sind Eure Öffnungszeiten? +";
            Q2Btn.Text = "Kann ich ein Probetraining absolvieren? +";
            Q3Btn.Text = "Welche Leistungen sind bei den jeweiligen Mitgliedschaften enthalten? +";
            Q4Btn.Text = "Ab welchem Alter kann ich bei FIT/ONE trainieren? +";
            Q5Btn.Text = "Bietet Ihr auch Tageskarten an? +";
            Q6Btn.Text = "Wie lange ist die (Mindest-)Vertragslaufzeit? +";
            Q7Btn.Text = "Ich möchte Kontakt zur Mitgliederverwaltung aufnehmen +";
        }

        private void Q1Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wir haben Montag bis Sonntag von 6 bis 24 Uhr für Euch geöffnet. Dies gilt – solange nichts anderes kommuniziert wird – auch für Feiertage", "Antwort");
        }

        private void Q2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerne kannst Du auf unserer Website einen Termin für ein einmalig kostenloses Probetraining vereinbaren.", "Antwort");
        }

        private void Q3Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basic:\n- 19,99€ Monatlich\n- keine Zusatzleistung\nSilber:\n- 24,99€ Monatlich\n- Kurse\n- Getränke\nGold:\n- 29,99€ Monatlich\n- Kurse\n- Getränke\n- Personal Trainer\n- Goldbereich", "Antwort");
        }

        private void Q4Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mit Einverständniserklärung ab 15 Jahren.", "Antwort");
        }

        private void Q5Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eine Tageskarte ist für 20 Euro erhältlich.", "Antwort");
        }

        private void Q6Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bei uns stehen Dir drei Laufzeiten zur Verfügung und Du hast die Wahl zwischen 23 Monaten, 12 Monaten oder 1 Monat.", "Antwort");
        }

        private void Q7Btn_Click(object sender, EventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow();
            chatWindow.ShowDialog();
        }
    }
}