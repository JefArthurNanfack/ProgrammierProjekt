using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;




namespace WeGo_UI
{
    public partial class Überwachung : Form
    {

        SerialPort serialPort;
        System.Windows.Forms.Timer updateTimer;

        public Überwachung()
        {
            InitializeComponent();
            SetupSerialPort();

        }

        private void SetupSerialPort()
        {
            serialPort = new SerialPort("COM5", 115200); // Setze COM Port und Baudrate
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen des SerialPorts: " + ex.Message);
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort.BytesToRead > 0)
                {
                    string data = serialPort.ReadLine();
                    if (int.TryParse(data.Trim(), out int sensorValue))
                    {
                        // Hier kannst du den empfangenen Sensorwert verarbeiten
                        UpdateProgressBar(sensorValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Empfangen der Daten: " + ex.Message);
            }

        }




        private void UpdateProgressBar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgressBar), value);
                return;
            }

            // Begrenze den Wert auf den Bereich der ProgressBar
            int boundedValue = Math.Min(Math.Max(value, progressBar3.Minimum), progressBar3.Maximum);
            progressBar3.Value = boundedValue;

            // Berechne den Prozentsatz
            int percentage = (int)((double)boundedValue / progressBar3.Maximum * 100);
            labelProgress.Text = $"{percentage}%";
        }


        private void Überwachung_Load(object sender, EventArgs e)
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;
            labelProgress.Text = "0%";
        }

        private void ÜKBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Überwachungskameras ük = new Überwachungskameras();
            ük.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Verwaltungshomepage vh = new Verwaltungshomepage();
            vh.Show();
            this.Close();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosed(e);
        }


        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

       
       
    }
}
