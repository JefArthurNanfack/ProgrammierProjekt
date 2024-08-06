namespace WeGo_UI
{
    partial class SupportWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportWindow));
            Q1Btn = new Button();
            Q2Btn = new Button();
            Q3Btn = new Button();
            Q4Btn = new Button();
            Q5Btn = new Button();
            Q6Btn = new Button();
            Q7Btn = new Button();
            pictureBox1 = new PictureBox();
            SupportBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Q1Btn
            // 
            Q1Btn.Location = new Point(16, 215);
            Q1Btn.Name = "Q1Btn";
            Q1Btn.Size = new Size(247, 154);
            Q1Btn.TabIndex = 0;
            Q1Btn.Text = "Wie sind Eure Öffnungszeiten? +";
            Q1Btn.UseVisualStyleBackColor = true;
            Q1Btn.Click += Q1Btn_Click;
            // 
            // Q2Btn
            // 
            Q2Btn.Location = new Point(280, 215);
            Q2Btn.Name = "Q2Btn";
            Q2Btn.Size = new Size(247, 154);
            Q2Btn.TabIndex = 1;
            Q2Btn.Text = "Kann ich ein Probetraining absolvieren? +";
            Q2Btn.UseVisualStyleBackColor = true;
            Q2Btn.Click += Q2Btn_Click;
            // 
            // Q3Btn
            // 
            Q3Btn.Location = new Point(545, 215);
            Q3Btn.Name = "Q3Btn";
            Q3Btn.Size = new Size(247, 154);
            Q3Btn.TabIndex = 2;
            Q3Btn.Text = "Welche Leistungen sind bei den jeweiligen Mitgliedschaften enthalten? +";
            Q3Btn.UseVisualStyleBackColor = true;
            Q3Btn.Click += Q3Btn_Click;
            // 
            // Q4Btn
            // 
            Q4Btn.Location = new Point(16, 390);
            Q4Btn.Name = "Q4Btn";
            Q4Btn.Size = new Size(247, 154);
            Q4Btn.TabIndex = 3;
            Q4Btn.Text = "Ab welchem Alter kann ich bei FIT/ONE trainieren? +";
            Q4Btn.UseVisualStyleBackColor = true;
            Q4Btn.Click += Q4Btn_Click;
            // 
            // Q5Btn
            // 
            Q5Btn.Location = new Point(280, 390);
            Q5Btn.Name = "Q5Btn";
            Q5Btn.Size = new Size(247, 154);
            Q5Btn.TabIndex = 4;
            Q5Btn.Text = "Bietet Ihr auch Tageskarten an? +";
            Q5Btn.UseVisualStyleBackColor = true;
            Q5Btn.Click += Q5Btn_Click;
            // 
            // Q6Btn
            // 
            Q6Btn.Location = new Point(545, 390);
            Q6Btn.Name = "Q6Btn";
            Q6Btn.Size = new Size(247, 154);
            Q6Btn.TabIndex = 5;
            Q6Btn.Text = "Wie lange ist die (Mindest-)Vertragslaufzeit? +";
            Q6Btn.UseVisualStyleBackColor = true;
            Q6Btn.Click += Q6Btn_Click;
            // 
            // Q7Btn
            // 
            Q7Btn.Location = new Point(280, 580);
            Q7Btn.Name = "Q7Btn";
            Q7Btn.Size = new Size(247, 154);
            Q7Btn.TabIndex = 7;
            Q7Btn.Text = "Ich möchte Kontakt zur Mitgliederverwaltung aufnehmen +";
            Q7Btn.UseVisualStyleBackColor = true;
            Q7Btn.Click += Q7Btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cyan;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // SupportBox
            // 
            SupportBox.BackColor = Color.Aqua;
            SupportBox.Font = new Font("Showcard Gothic", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupportBox.ForeColor = SystemColors.ControlLightLight;
            SupportBox.Location = new Point(300, 21);
            SupportBox.Name = "SupportBox";
            SupportBox.ReadOnly = true;
            SupportBox.RightToLeft = RightToLeft.No;
            SupportBox.Size = new Size(473, 179);
            SupportBox.TabIndex = 11;
            SupportBox.Text = "Greetings\nI'm WeGoTron\n\nHow can I be of service ?\n\n";
            // 
            // SupportWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = Properties.Resources.hvDJo_9F;
            ClientSize = new Size(800, 799);
            Controls.Add(SupportBox);
            Controls.Add(pictureBox1);
            Controls.Add(Q7Btn);
            Controls.Add(Q6Btn);
            Controls.Add(Q5Btn);
            Controls.Add(Q4Btn);
            Controls.Add(Q3Btn);
            Controls.Add(Q2Btn);
            Controls.Add(Q1Btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 846);
            MinimumSize = new Size(818, 846);
            Name = "SupportWindow";
            Text = "Support";
            Load += SupportWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Q1Btn;
        private Button Q2Btn;
        private Button Q3Btn;
        private Button Q4Btn;
        private Button Q5Btn;
        private Button Q6Btn;
        private Button Q7Btn;
        private PictureBox pictureBox1;
        private RichTextBox SupportBox;
    }
}
