namespace WeGo_UI
{
    partial class Neue_Kunde
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Neue_Kunde));
            panel1 = new Panel();
            label2 = new Label();
            nmbox = new TextBox();
            Vnlabel = new Label();
            Nhlabel = new Label();
            Ghlabel = new Label();
            Nrlabel = new Label();
            Gblabel = new Label();
            Emlabel = new Label();
            emBox = new TextBox();
            nrBox = new TextBox();
            nachBox = new TextBox();
            gbTimePicker = new DateTimePicker();
            wtbtn = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            IBAN = new Label();
            textBox2 = new TextBox();
            infoBtn = new Button();
            label4 = new Label();
            StraßeLabel = new Label();
            Straße_TextBox = new TextBox();
            textBox3 = new TextBox();
            PLZ_Label = new Label();
            HausNr_Label = new Label();
            Stadt_Label = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Straße_Label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label3 = new Label();
            GeschlechtBox = new TextBox();
            KILabel = new Label();
            PassBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(2, 4, 2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 124);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(60, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 36);
            label2.TabIndex = 7;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // nmbox
            // 
            nmbox.Location = new Point(256, 208);
            nmbox.Margin = new Padding(2, 4, 2, 4);
            nmbox.Name = "nmbox";
            nmbox.Size = new Size(170, 27);
            nmbox.TabIndex = 1;
            nmbox.TextChanged += nmbox_TextChanged;
            // 
            // Vnlabel
            // 
            Vnlabel.AutoSize = true;
            Vnlabel.BackColor = Color.Transparent;
            Vnlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vnlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Vnlabel.Location = new Point(73, 208);
            Vnlabel.Margin = new Padding(2, 0, 2, 0);
            Vnlabel.Name = "Vnlabel";
            Vnlabel.Size = new Size(79, 16);
            Vnlabel.TabIndex = 2;
            Vnlabel.Text = "First name";
            // 
            // Nhlabel
            // 
            Nhlabel.AutoSize = true;
            Nhlabel.BackColor = Color.Transparent;
            Nhlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nhlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Nhlabel.Location = new Point(73, 272);
            Nhlabel.Margin = new Padding(2, 0, 2, 0);
            Nhlabel.Name = "Nhlabel";
            Nhlabel.Size = new Size(78, 16);
            Nhlabel.TabIndex = 3;
            Nhlabel.Text = "Last name";
            Nhlabel.Click += Nhlabel_Click;
            // 
            // Ghlabel
            // 
            Ghlabel.AutoSize = true;
            Ghlabel.BackColor = Color.Transparent;
            Ghlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ghlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Ghlabel.Location = new Point(73, 336);
            Ghlabel.Margin = new Padding(2, 0, 2, 0);
            Ghlabel.Name = "Ghlabel";
            Ghlabel.Size = new Size(58, 16);
            Ghlabel.TabIndex = 4;
            Ghlabel.Text = "Gender";
            // 
            // Nrlabel
            // 
            Nrlabel.AutoSize = true;
            Nrlabel.BackColor = Color.Transparent;
            Nrlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nrlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Nrlabel.Location = new Point(72, 526);
            Nrlabel.Margin = new Padding(2, 0, 2, 0);
            Nrlabel.Name = "Nrlabel";
            Nrlabel.Size = new Size(73, 16);
            Nrlabel.TabIndex = 5;
            Nrlabel.Text = "Nummber";
            // 
            // Gblabel
            // 
            Gblabel.AutoSize = true;
            Gblabel.BackColor = Color.Transparent;
            Gblabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gblabel.ForeColor = Color.FromArgb(0, 192, 0);
            Gblabel.Location = new Point(73, 399);
            Gblabel.Margin = new Padding(2, 0, 2, 0);
            Gblabel.Name = "Gblabel";
            Gblabel.Size = new Size(72, 16);
            Gblabel.TabIndex = 6;
            Gblabel.Text = "birth date";
            Gblabel.Click += Gblabel_Click;
            // 
            // Emlabel
            // 
            Emlabel.AutoSize = true;
            Emlabel.BackColor = Color.Transparent;
            Emlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Emlabel.Location = new Point(73, 465);
            Emlabel.Margin = new Padding(2, 0, 2, 0);
            Emlabel.Name = "Emlabel";
            Emlabel.Size = new Size(46, 16);
            Emlabel.TabIndex = 8;
            Emlabel.Text = "Email";
            // 
            // emBox
            // 
            emBox.Location = new Point(256, 459);
            emBox.Margin = new Padding(2, 4, 2, 4);
            emBox.Name = "emBox";
            emBox.Size = new Size(180, 27);
            emBox.TabIndex = 9;
            emBox.TextChanged += emBox_TextChanged;
            // 
            // nrBox
            // 
            nrBox.Location = new Point(256, 524);
            nrBox.Margin = new Padding(2, 4, 2, 4);
            nrBox.Name = "nrBox";
            nrBox.Size = new Size(180, 27);
            nrBox.TabIndex = 10;
            nrBox.TextChanged += nrBox_TextChanged;
            // 
            // nachBox
            // 
            nachBox.Location = new Point(256, 271);
            nachBox.Margin = new Padding(2, 4, 2, 4);
            nachBox.Name = "nachBox";
            nachBox.Size = new Size(170, 27);
            nachBox.TabIndex = 12;
            nachBox.TextChanged += nachBox_TextChanged;
            // 
            // gbTimePicker
            // 
            gbTimePicker.Location = new Point(254, 398);
            gbTimePicker.Margin = new Padding(2, 4, 2, 4);
            gbTimePicker.Name = "gbTimePicker";
            gbTimePicker.Size = new Size(270, 27);
            gbTimePicker.TabIndex = 13;
            gbTimePicker.ValueChanged += gbTimePicker_ValueChanged;
            // 
            // wtbtn
            // 
            wtbtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wtbtn.ForeColor = Color.FromArgb(0, 192, 0);
            wtbtn.Location = new Point(1019, 660);
            wtbtn.Margin = new Padding(2, 4, 2, 4);
            wtbtn.Name = "wtbtn";
            wtbtn.Size = new Size(112, 50);
            wtbtn.TabIndex = 18;
            wtbtn.Text = "countinue";
            wtbtn.UseVisualStyleBackColor = true;
            wtbtn.Click += wtbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(590, 401);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 19;
            label1.Text = "Tariff type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basis", "Silber", "Gold" });
            comboBox1.Location = new Point(774, 396);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 20;
            // 
            // IBAN
            // 
            IBAN.AutoSize = true;
            IBAN.BackColor = Color.Transparent;
            IBAN.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IBAN.ForeColor = Color.FromArgb(0, 192, 0);
            IBAN.Location = new Point(590, 530);
            IBAN.Margin = new Padding(2, 0, 2, 0);
            IBAN.Name = "IBAN";
            IBAN.Size = new Size(43, 17);
            IBAN.TabIndex = 23;
            IBAN.Text = "IBAN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(774, 522);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // infoBtn
            // 
            infoBtn.BackgroundImage = Properties.Resources.die_info;
            infoBtn.Font = new Font("MS Reference Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infoBtn.ForeColor = Color.FromArgb(0, 192, 0);
            infoBtn.Image = Properties.Resources.die_info;
            infoBtn.Location = new Point(925, 395);
            infoBtn.Margin = new Padding(2);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(30, 31);
            infoBtn.TabIndex = 25;
            infoBtn.Text = "i";
            infoBtn.UseVisualStyleBackColor = true;
            infoBtn.Click += infoBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, -221);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 28;
            label4.Text = "label4";
            // 
            // StraßeLabel
            // 
            StraßeLabel.AutoSize = true;
            StraßeLabel.BackColor = Color.Transparent;
            StraßeLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StraßeLabel.ForeColor = Color.FromArgb(0, 192, 0);
            StraßeLabel.Location = new Point(590, 208);
            StraßeLabel.Margin = new Padding(2, 0, 2, 0);
            StraßeLabel.Name = "StraßeLabel";
            StraßeLabel.Size = new Size(48, 16);
            StraßeLabel.TabIndex = 29;
            StraßeLabel.Text = "Street";
            StraßeLabel.Click += label5_Click;
            // 
            // Straße_TextBox
            // 
            Straße_TextBox.Location = new Point(771, 204);
            Straße_TextBox.Margin = new Padding(2, 4, 2, 4);
            Straße_TextBox.Name = "Straße_TextBox";
            Straße_TextBox.Size = new Size(135, 27);
            Straße_TextBox.TabIndex = 30;
            Straße_TextBox.TextChanged += Straße_TextBox_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(771, 265);
            textBox3.Margin = new Padding(2, 4, 2, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // PLZ_Label
            // 
            PLZ_Label.AutoSize = true;
            PLZ_Label.BackColor = Color.Transparent;
            PLZ_Label.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PLZ_Label.ForeColor = Color.FromArgb(0, 192, 0);
            PLZ_Label.Location = new Point(590, 336);
            PLZ_Label.Margin = new Padding(2, 0, 2, 0);
            PLZ_Label.Name = "PLZ_Label";
            PLZ_Label.Size = new Size(30, 16);
            PLZ_Label.TabIndex = 32;
            PLZ_Label.Text = "ZIP";
            PLZ_Label.Click += PLZ_Label_Click;
            // 
            // HausNr_Label
            // 
            HausNr_Label.AutoSize = true;
            HausNr_Label.BackColor = Color.Transparent;
            HausNr_Label.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HausNr_Label.ForeColor = Color.FromArgb(0, 192, 0);
            HausNr_Label.Location = new Point(590, 265);
            HausNr_Label.Margin = new Padding(2, 0, 2, 0);
            HausNr_Label.Name = "HausNr_Label";
            HausNr_Label.Size = new Size(68, 16);
            HausNr_Label.TabIndex = 33;
            HausNr_Label.Text = "HouseNr";
            // 
            // Stadt_Label
            // 
            Stadt_Label.AutoSize = true;
            Stadt_Label.BackColor = Color.Transparent;
            Stadt_Label.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stadt_Label.ForeColor = Color.FromArgb(0, 192, 0);
            Stadt_Label.Location = new Point(881, 338);
            Stadt_Label.Margin = new Padding(2, 0, 2, 0);
            Stadt_Label.Name = "Stadt_Label";
            Stadt_Label.Size = new Size(33, 16);
            Stadt_Label.TabIndex = 34;
            Stadt_Label.Text = "City";
            Stadt_Label.Click += Stadt_Label_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(771, 335);
            textBox4.Margin = new Padding(2, 4, 2, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 35;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(931, 336);
            textBox5.Margin = new Padding(2, 4, 2, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 27);
            textBox5.TabIndex = 36;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Straße_Label2
            // 
            Straße_Label2.AutoSize = true;
            Straße_Label2.Location = new Point(782, 239);
            Straße_Label2.Margin = new Padding(2, 0, 2, 0);
            Straße_Label2.Name = "Straße_Label2";
            Straße_Label2.Size = new Size(0, 20);
            Straße_Label2.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 490);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 39;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 555);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(774, 555);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(933, 366);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 44;
            // 
            // GeschlechtBox
            // 
            GeschlechtBox.Location = new Point(253, 333);
            GeschlechtBox.Margin = new Padding(2, 3, 2, 3);
            GeschlechtBox.Name = "GeschlechtBox";
            GeschlechtBox.Size = new Size(174, 27);
            GeschlechtBox.TabIndex = 45;
            // 
            // KILabel
            // 
            KILabel.AutoSize = true;
            KILabel.BackColor = Color.Transparent;
            KILabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KILabel.ForeColor = Color.FromArgb(0, 192, 0);
            KILabel.Location = new Point(590, 462);
            KILabel.Margin = new Padding(2, 0, 2, 0);
            KILabel.Name = "KILabel";
            KILabel.Size = new Size(77, 17);
            KILabel.TabIndex = 21;
            KILabel.Text = "Password";
            // 
            // PassBox
            // 
            PassBox.Location = new Point(771, 460);
            PassBox.Margin = new Padding(2);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(180, 27);
            PassBox.TabIndex = 22;
            PassBox.TextChanged += textBox1_TextChanged;
            // 
            // Neue_Kunde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1213, 840);
            Controls.Add(GeschlechtBox);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Straße_Label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(Stadt_Label);
            Controls.Add(HausNr_Label);
            Controls.Add(PLZ_Label);
            Controls.Add(textBox3);
            Controls.Add(Straße_TextBox);
            Controls.Add(StraßeLabel);
            Controls.Add(label4);
            Controls.Add(infoBtn);
            Controls.Add(textBox2);
            Controls.Add(IBAN);
            Controls.Add(PassBox);
            Controls.Add(KILabel);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(wtbtn);
            Controls.Add(gbTimePicker);
            Controls.Add(nachBox);
            Controls.Add(nrBox);
            Controls.Add(emBox);
            Controls.Add(Emlabel);
            Controls.Add(Gblabel);
            Controls.Add(Nrlabel);
            Controls.Add(Ghlabel);
            Controls.Add(Nhlabel);
            Controls.Add(Vnlabel);
            Controls.Add(nmbox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "Neue_Kunde";
            Text = "New Customer";
            Load += Neue_Kunde_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nmbox;
        private System.Windows.Forms.Label Vnlabel;
        private System.Windows.Forms.Label Nhlabel;
        private System.Windows.Forms.Label Ghlabel;
        private System.Windows.Forms.Label Nrlabel;
        private System.Windows.Forms.Label Gblabel;
        private System.Windows.Forms.Label Emlabel;
        private System.Windows.Forms.TextBox emBox;
        private System.Windows.Forms.TextBox nrBox;
        private System.Windows.Forms.TextBox nachBox;
        private System.Windows.Forms.DateTimePicker gbTimePicker;
        private System.Windows.Forms.Button wtbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label IBAN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StraßeLabel;
        private System.Windows.Forms.TextBox Straße_TextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label PLZ_Label;
        private System.Windows.Forms.Label HausNr_Label;
        private System.Windows.Forms.Label Stadt_Label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Straße_Label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GeschlechtBox;
        private Label KILabel;
        private TextBox PassBox;
    }
}