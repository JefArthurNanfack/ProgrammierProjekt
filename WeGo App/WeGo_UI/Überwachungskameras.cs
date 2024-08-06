using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;


namespace WeGo_UI
{
    public partial class Überwachungskameras : Form
    {
        public VideoCaptureDevice videoQuellen;
        public bool IstKameraAmLAufen = false;

        public Überwachungskameras()
        {
            InitializeComponent();
            this.KStartBtn.Click += new System.EventHandler(this.KStartBtn_Click);
            this.KStopBtn.Click += new System.EventHandler(this.KStopBtn_Click);
        }

        private void Überwachungskameras_Load(object sender, EventArgs e)
        {
            // Video devices initialization moved here, but not starting the camera
            FilterInfoCollection videoGeräte = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoGeräte.Count == 0)
            {
                MessageBox.Show("Keine Videoquelle gefunden");
                return;
            }
            videoQuellen = new VideoCaptureDevice(videoGeräte[0].MonikerString);
            videoQuellen.NewFrame += VideoDevice_NewFrame;
        }

        private void KStartBtn_Click(object sender, EventArgs e)
        {
            if (videoQuellen != null && !IstKameraAmLAufen)
            {
                try
                {
                    videoQuellen.Start();
                    IstKameraAmLAufen = true;
                    MessageBox.Show("Kamera gestartet");  // Debugging-Ausgabe
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Starten der Kamera: " + ex.Message);
                }
            }
            else if (IstKameraAmLAufen)
            {
                MessageBox.Show("Kamera läuft bereits");
            }
            else
            {
                MessageBox.Show("Videoquelle ist nicht verfügbar");
            }
        }

        private void KStopBtn_Click(object sender, EventArgs e)
        {
            if (videoQuellen != null && IstKameraAmLAufen)
            {
                try
                {
                    videoQuellen.SignalToStop();
                    videoQuellen.WaitForStop();
                    IstKameraAmLAufen = false;
                    MessageBox.Show("Kamera gestoppt");  // Debugging-Ausgabe
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Stoppen der Kamera: " + ex.Message);
                }
            }
            else if (!IstKameraAmLAufen)
            {
                MessageBox.Show("Kamera läuft nicht");
            }
            else
            {
                MessageBox.Show("Videoquelle ist nicht verfügbar");
            }
        }

        private void VideoDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                // Adjust the frame orientation if necessary
                // frame.RotateFlip(RotateFlipType.Rotate90FlipNone); // Example rotation, adjust as needed

                pictureBox1.Invoke(new Action(() =>
                {
                    pictureBox1.Image = frame;
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Abrufen des neuen Frames: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoQuellen != null && videoQuellen.IsRunning)
            {
                videoQuellen.SignalToStop();
                videoQuellen.WaitForStop();
                videoQuellen = null;
            }
            base.OnFormClosing(e);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Überwachung üb = new Überwachung();
            üb.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
