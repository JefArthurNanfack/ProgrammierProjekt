namespace WeGo_UI
{
    partial class Überwachungskameras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Überwachungskameras));
            KStartBtn = new Button();
            KStopBtn = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BackBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // KStartBtn
            // 
            KStartBtn.ForeColor = Color.FromArgb(0, 192, 0);
            KStartBtn.Location = new Point(32, 369);
            KStartBtn.Name = "KStartBtn";
            KStartBtn.Size = new Size(98, 46);
            KStartBtn.TabIndex = 14;
            KStartBtn.Text = "Start";
            KStartBtn.UseVisualStyleBackColor = true;
            // 
            // KStopBtn
            // 
            KStopBtn.ForeColor = Color.FromArgb(0, 192, 0);
            KStopBtn.Location = new Point(590, 369);
            KStopBtn.Name = "KStopBtn";
            KStopBtn.Size = new Size(98, 46);
            KStopBtn.TabIndex = 15;
            KStopBtn.Text = "Stop";
            KStopBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 223);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(BackBtn);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(711, 124);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.AliceBlue;
            BackBtn.Image = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_261;
            BackBtn.Location = new Point(10, 49);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(29, 31);
            BackBtn.TabIndex = 5;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(343, 39);
            label1.TabIndex = 0;
            label1.Text = "Surveillance cameras";
            // 
            // Überwachungskameras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_182;
            ClientSize = new Size(711, 450);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(KStopBtn);
            Controls.Add(KStartBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Überwachungskameras";
            Text = "Surveillance cameras";
            Load += Überwachungskameras_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button KStartBtn;
        private System.Windows.Forms.Button KStopBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
    }
}