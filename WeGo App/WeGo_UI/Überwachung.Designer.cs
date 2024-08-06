namespace WeGo_UI
{
    partial class Überwachung
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Überwachung));
            Wasser = new Label();
            progressBar3 = new ProgressBar();
            ÜKBtn = new Button();
            panel3 = new Panel();
            BackBtn = new Button();
            ÜberwachungAbteilung = new Label();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            labelProgress = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Wasser
            // 
            Wasser.AutoSize = true;
            Wasser.BackColor = Color.Transparent;
            Wasser.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Wasser.ForeColor = Color.FromArgb(0, 192, 0);
            Wasser.Location = new Point(29, 293);
            Wasser.Margin = new Padding(2, 0, 2, 0);
            Wasser.Name = "Wasser";
            Wasser.Size = new Size(90, 17);
            Wasser.TabIndex = 5;
            Wasser.Text = "Water level";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(32, 342);
            progressBar3.Margin = new Padding(2, 2, 2, 2);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(641, 42);
            progressBar3.TabIndex = 6;
            progressBar3.Click += progressBar3_Click;
            // 
            // ÜKBtn
            // 
            ÜKBtn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ÜKBtn.ForeColor = Color.FromArgb(0, 192, 0);
            ÜKBtn.Location = new Point(40, 628);
            ÜKBtn.Margin = new Padding(2, 2, 2, 2);
            ÜKBtn.Name = "ÜKBtn";
            ÜKBtn.Size = new Size(208, 38);
            ÜKBtn.TabIndex = 15;
            ÜKBtn.Text = "Surveillance cameras";
            ÜKBtn.UseVisualStyleBackColor = true;
            ÜKBtn.Click += ÜKBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(BackBtn);
            panel3.Controls.Add(ÜberwachungAbteilung);
            panel3.Location = new Point(-1, 2);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 124);
            panel3.TabIndex = 7;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.ForeColor = Color.Transparent;
            BackBtn.Image = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_26_59;
            BackBtn.Location = new Point(11, 48);
            BackBtn.Margin = new Padding(2, 3, 2, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(30, 31);
            BackBtn.TabIndex = 4;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ÜberwachungAbteilung
            // 
            ÜberwachungAbteilung.AutoSize = true;
            ÜberwachungAbteilung.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ÜberwachungAbteilung.ForeColor = Color.FromArgb(0, 192, 0);
            ÜberwachungAbteilung.Location = new Point(78, 41);
            ÜberwachungAbteilung.Margin = new Padding(2, 0, 2, 0);
            ÜberwachungAbteilung.Name = "ÜberwachungAbteilung";
            ÜberwachungAbteilung.Size = new Size(198, 39);
            ÜberwachungAbteilung.TabIndex = 0;
            ÜberwachungAbteilung.Text = "surveillance";
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(270, 353);
            labelProgress.Margin = new Padding(2, 0, 2, 0);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(0, 20);
            labelProgress.TabIndex = 16;
            // 
            // Überwachung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_181;
            ClientSize = new Size(737, 840);
            Controls.Add(labelProgress);
            Controls.Add(panel3);
            Controls.Add(ÜKBtn);
            Controls.Add(progressBar3);
            Controls.Add(Wasser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Überwachung";
            Text = "surveillance";
            Load += Überwachung_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label Wasser;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button ÜKBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ÜberwachungAbteilung;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Timer UpdateTimer;
        private Label labelProgress;
    }
}