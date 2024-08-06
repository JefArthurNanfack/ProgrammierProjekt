namespace WeGo_UI
{
    partial class ProfilBearbeitenWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilBearbeitenWindow));
            SilBtn = new Button();
            BasBtn = new Button();
            GoldBnt = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // SilBtn
            // 
            SilBtn.BackColor = Color.Silver;
            SilBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SilBtn.ForeColor = Color.FromArgb(0, 192, 0);
            SilBtn.Location = new Point(625, 181);
            SilBtn.Margin = new Padding(3, 2, 3, 2);
            SilBtn.Name = "SilBtn";
            SilBtn.Size = new Size(155, 60);
            SilBtn.TabIndex = 2;
            SilBtn.Text = "Silber abo";
            SilBtn.UseVisualStyleBackColor = false;
            SilBtn.Click += SilBtn_Click;
            // 
            // BasBtn
            // 
            BasBtn.BackColor = Color.Transparent;
            BasBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BasBtn.ForeColor = Color.FromArgb(0, 192, 0);
            BasBtn.Location = new Point(401, 181);
            BasBtn.Margin = new Padding(3, 2, 3, 2);
            BasBtn.Name = "BasBtn";
            BasBtn.Size = new Size(155, 60);
            BasBtn.TabIndex = 3;
            BasBtn.Text = "Basic Abo";
            BasBtn.UseVisualStyleBackColor = false;
            BasBtn.Click += BasBtn_Click;
            // 
            // GoldBnt
            // 
            GoldBnt.BackColor = Color.Gold;
            GoldBnt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoldBnt.ForeColor = Color.FromArgb(0, 192, 0);
            GoldBnt.Location = new Point(839, 181);
            GoldBnt.Margin = new Padding(3, 2, 3, 2);
            GoldBnt.Name = "GoldBnt";
            GoldBnt.Size = new Size(155, 60);
            GoldBnt.TabIndex = 4;
            GoldBnt.Text = "Gold Abo";
            GoldBnt.UseVisualStyleBackColor = false;
            GoldBnt.Click += GoldBnt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 655);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Bernard MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(625, 56);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 6;
            label1.Text = "Abo ändern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(151, 60);
            label2.TabIndex = 7;
            label2.Text = "- 19,99 €\r\n\r\n- Kein Zusatzleistung ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(401, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 283);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(625, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 283);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(74, 140);
            label3.TabIndex = 7;
            label3.Text = "- 24,99 €\r\n\r\n- Sauna\r\n\r\n- Kurse\r\n\r\n-Getränke";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(839, 246);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(155, 283);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 46);
            label4.Name = "label4";
            label4.Size = new Size(117, 220);
            label4.TabIndex = 7;
            label4.Text = "- 29,99 €\r\n\r\n- Sauna\r\n\r\n- Kurse\r\n\r\n- Getränke\r\n\r\n- Personaltrainer\r\n\r\n- Goldbereich";
            // 
            // ProfilBearbeitenWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1060, 650);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(GoldBnt);
            Controls.Add(BasBtn);
            Controls.Add(SilBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProfilBearbeitenWindow";
            Text = "ProfilBearbeitenWindow";
            Load += ProfilBearbeitenWindow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SilBtn;
        private Button BasBtn;
        private Button GoldBnt;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private GroupBox groupBox3;
        private Label label4;
    }
}