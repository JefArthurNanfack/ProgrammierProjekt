namespace WeGo_UI
{
    partial class WeGo_Gym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeGo_Gym));
            BtnAnmelden = new Button();
            BtnRegister = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            CloseBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtnAnmelden
            // 
            BtnAnmelden.BackColor = Color.FromArgb(0, 192, 192);
            BtnAnmelden.Cursor = Cursors.Hand;
            BtnAnmelden.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            BtnAnmelden.ForeColor = Color.White;
            BtnAnmelden.Location = new Point(221, 335);
            BtnAnmelden.Name = "BtnAnmelden";
            BtnAnmelden.Size = new Size(229, 75);
            BtnAnmelden.TabIndex = 3;
            BtnAnmelden.Text = "Anmelden";
            BtnAnmelden.UseVisualStyleBackColor = false;
            BtnAnmelden.Click += BtnAnmelden_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = SystemColors.ActiveBorder;
            BtnRegister.Cursor = Cursors.Hand;
            BtnRegister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            BtnRegister.ForeColor = Color.White;
            BtnRegister.Location = new Point(221, 578);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(229, 65);
            BtnRegister.TabIndex = 4;
            BtnRegister.Text = "Registrieren";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 883);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(4, 788);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(314, 63);
            label4.TabIndex = 7;
            label4.Text = "Entwickelt von :\r\nAhmad Amairy , Jef Arthur Nanfack ,\r\nRashad Mardini, Zia Mustafa\r\n";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(4, 457);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(504, 81);
            label2.TabIndex = 6;
            label2.Text = "Ihrer ultimativen Desktop-App für effizientes\r\nGym-Management! Wir freuen uns,Sie in \r\nunserer Community begrüßen zu dürfen.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 255, 128);
            label1.Location = new Point(36, 387);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 39);
            label1.TabIndex = 5;
            label1.Text = "Willkommen bei Wego!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CloseBtn);
            panel2.Controls.Add(BtnAnmelden);
            panel2.Controls.Add(BtnRegister);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(469, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 883);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(137, 843);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(224, 25);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "WeGo_Gym49@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(4, 788);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(521, 63);
            label3.TabIndex = 11;
            label3.Text = "Support:\r\nBei Fragen könenen sie sich an unsere Kundenservice wenden\r\nEmail Addresse  : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(67, 457);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(560, 78);
            label6.TabIndex = 10;
            label6.Text = "Haben sie noch kein Konto ! Dann \r\nkönnen sie sich hier registrieren ";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Screenshot_2024_06_08_193545;
            pictureBox2.Location = new Point(151, 335);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(101, 258);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(498, 39);
            label5.TabIndex = 8;
            label5.Text = "Melden sich in ihrem Konto an ";
            // 
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.FlatAppearance.BorderSize = 0;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseBtn.ForeColor = Color.FromArgb(0, 192, 192);
            CloseBtn.Location = new Point(546, 0);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(57, 67);
            CloseBtn.TabIndex = 5;
            CloseBtn.Text = "X";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // WeGo_Gym
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1071, 883);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WeGo_Gym";
            Text = "WeGo_Gym";
            Load += WeGo_Gym_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAnmelden;
        private Button BtnRegister;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button CloseBtn;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}