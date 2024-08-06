namespace WeGo_UI
{
    partial class KundenHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenHomepage));
            SBtn = new Button();
            EBtn = new Button();
            EEBtn = new Button();
            KBtn = new Button();
            WPEBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SBtn
            // 
            SBtn.BackColor = Color.FromArgb(255, 128, 128);
            SBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            SBtn.Image = (Image)resources.GetObject("SBtn.Image");
            SBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SBtn.Location = new Point(14, 673);
            SBtn.Name = "SBtn";
            SBtn.Size = new Size(302, 85);
            SBtn.TabIndex = 1;
            SBtn.Text = "             Support";
            SBtn.UseVisualStyleBackColor = false;
            SBtn.Click += SBtn_Click;
            // 
            // EBtn
            // 
            EBtn.BackColor = Color.FromArgb(192, 255, 255);
            EBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            EBtn.Image = (Image)resources.GetObject("EBtn.Image");
            EBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EBtn.Location = new Point(14, 573);
            EBtn.Name = "EBtn";
            EBtn.Size = new Size(302, 83);
            EBtn.TabIndex = 3;
            EBtn.Text = "            Events";
            EBtn.UseVisualStyleBackColor = false;
            EBtn.Click += button1_Click_1;
            // 
            // EEBtn
            // 
            EEBtn.BackColor = Color.FromArgb(192, 255, 192);
            EEBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            EEBtn.Image = Properties.Resources.Screenshot_2024_06_05_215357;
            EEBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EEBtn.Location = new Point(14, 244);
            EEBtn.Name = "EEBtn";
            EEBtn.Size = new Size(302, 88);
            EEBtn.TabIndex = 4;
            EEBtn.Text = "                    Make a Meal-Plan";
            EEBtn.UseVisualStyleBackColor = false;
            EEBtn.Click += EEBtn_Click;
            // 
            // KBtn
            // 
            KBtn.BackColor = Color.FromArgb(64, 64, 64);
            KBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            KBtn.Image = (Image)resources.GetObject("KBtn.Image");
            KBtn.ImageAlign = ContentAlignment.MiddleLeft;
            KBtn.Location = new Point(14, 469);
            KBtn.Name = "KBtn";
            KBtn.Size = new Size(302, 85);
            KBtn.TabIndex = 2;
            KBtn.Text = "          Courses";
            KBtn.UseVisualStyleBackColor = false;
            KBtn.Click += KBtn_Click;
            // 
            // WPEBtn
            // 
            WPEBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            WPEBtn.Image = (Image)resources.GetObject("WPEBtn.Image");
            WPEBtn.ImageAlign = ContentAlignment.MiddleLeft;
            WPEBtn.Location = new Point(14, 356);
            WPEBtn.Name = "WPEBtn";
            WPEBtn.Size = new Size(302, 87);
            WPEBtn.TabIndex = 5;
            WPEBtn.Text = "                 Make a Workout-Plan";
            WPEBtn.UseVisualStyleBackColor = true;
            WPEBtn.Click += WPEBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 39);
            label1.TabIndex = 7;
            label1.Text = "WeGo ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 116);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // KundenHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F;
            ClientSize = new Size(667, 768);
            Controls.Add(panel1);
            Controls.Add(WPEBtn);
            Controls.Add(EEBtn);
            Controls.Add(EBtn);
            Controls.Add(KBtn);
            Controls.Add(SBtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(685, 815);
            MinimumSize = new Size(685, 815);
            Name = "KundenHomepage";
            Text = "Homepage";
            Load += KundenHomepage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SBtn;
        private Button EBtn;
        private Button EEBtn;
        private Button KBtn;
        private Button WPEBtn;
        private Label label1;
        private Panel panel1;
    }
}