namespace WeGo_UI
{
    partial class KurseWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurseWindow));
            BtnAnmelden = new Button();
            BtnAbmelden = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DateLb = new Label();
            Ftrbtn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            CBoxFuntional = new CheckBox();
            CBoxStretch = new CheckBox();
            CBoxPower = new CheckBox();
            CBoxFit = new CheckBox();
            CBoxAerobic = new CheckBox();
            CBoxRückenfit = new CheckBox();
            SuspendLayout();
            // 
            // BtnAnmelden
            // 
            BtnAnmelden.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAnmelden.ForeColor = Color.ForestGreen;
            BtnAnmelden.Location = new Point(234, 564);
            BtnAnmelden.Name = "BtnAnmelden";
            BtnAnmelden.Size = new Size(103, 43);
            BtnAnmelden.TabIndex = 6;
            BtnAnmelden.Text = "Anmelden";
            BtnAnmelden.UseVisualStyleBackColor = true;
            BtnAnmelden.Click += BtnAnmelden_Click;
            // 
            // BtnAbmelden
            // 
            BtnAbmelden.ForeColor = Color.ForestGreen;
            BtnAbmelden.Location = new Point(406, 564);
            BtnAbmelden.Name = "BtnAbmelden";
            BtnAbmelden.Size = new Size(103, 43);
            BtnAbmelden.TabIndex = 7;
            BtnAbmelden.Text = "Abmelden";
            BtnAbmelden.UseVisualStyleBackColor = true;
            BtnAbmelden.Click += BtnAbmelden_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 333);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 14;
            label1.Text = "Fit und Fight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 253);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 37);
            label2.TabIndex = 18;
            label2.Text = "Power Workout";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 411);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 19;
            label3.Text = "Step Aerobic";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 95);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(239, 37);
            label4.TabIndex = 20;
            label4.Text = "Funtional Training";
            // 
            // DateLb
            // 
            DateLb.AutoSize = true;
            DateLb.BackColor = SystemColors.GradientInactiveCaption;
            DateLb.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLb.Location = new Point(13, 171);
            DateLb.Margin = new Padding(2, 0, 2, 0);
            DateLb.Name = "DateLb";
            DateLb.Size = new Size(231, 37);
            DateLb.TabIndex = 25;
            DateLb.Text = "Stretch und Relax";
            DateLb.Click += DateLb_Click;
            // 
            // Ftrbtn
            // 
            Ftrbtn.Location = new Point(406, 93);
            Ftrbtn.Margin = new Padding(3, 4, 3, 4);
            Ftrbtn.Name = "Ftrbtn";
            Ftrbtn.Size = new Size(147, 41);
            Ftrbtn.TabIndex = 31;
            Ftrbtn.Text = "Kurs infos";
            Ftrbtn.UseVisualStyleBackColor = true;
            Ftrbtn.Click += Ftrbtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 332);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(147, 41);
            button3.TabIndex = 32;
            button3.Text = "Kurs infos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(406, 252);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(147, 40);
            button4.TabIndex = 33;
            button4.Text = "Kurs infos";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(406, 169);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(147, 45);
            button5.TabIndex = 34;
            button5.Text = "Kurs infos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(406, 409);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(147, 44);
            button6.TabIndex = 35;
            button6.Text = "Kurs infos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(406, 483);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(147, 44);
            button2.TabIndex = 39;
            button2.Text = "Kurs infos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 487);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(133, 37);
            label6.TabIndex = 37;
            label6.Text = "Rückenfit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Snap ITC", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(185, 12);
            label7.Name = "label7";
            label7.Size = new Size(463, 44);
            label7.TabIndex = 40;
            label7.Text = "Kursangebot bei Wego";
            // 
            // CBoxFuntional
            // 
            CBoxFuntional.AutoSize = true;
            CBoxFuntional.CheckAlign = ContentAlignment.TopLeft;
            CBoxFuntional.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxFuntional.Location = new Point(264, 103);
            CBoxFuntional.Margin = new Padding(3, 4, 3, 4);
            CBoxFuntional.Name = "CBoxFuntional";
            CBoxFuntional.Size = new Size(88, 32);
            CBoxFuntional.TabIndex = 41;
            CBoxFuntional.Text = "Select";
            CBoxFuntional.UseVisualStyleBackColor = true;
            // 
            // CBoxStretch
            // 
            CBoxStretch.AutoSize = true;
            CBoxStretch.CheckAlign = ContentAlignment.TopLeft;
            CBoxStretch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxStretch.Location = new Point(261, 177);
            CBoxStretch.Margin = new Padding(3, 4, 3, 4);
            CBoxStretch.Name = "CBoxStretch";
            CBoxStretch.Size = new Size(88, 32);
            CBoxStretch.TabIndex = 42;
            CBoxStretch.Text = "Select";
            CBoxStretch.UseVisualStyleBackColor = true;
            // 
            // CBoxPower
            // 
            CBoxPower.AutoSize = true;
            CBoxPower.CheckAlign = ContentAlignment.TopLeft;
            CBoxPower.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxPower.Location = new Point(261, 259);
            CBoxPower.Margin = new Padding(3, 4, 3, 4);
            CBoxPower.Name = "CBoxPower";
            CBoxPower.Size = new Size(88, 32);
            CBoxPower.TabIndex = 43;
            CBoxPower.Text = "Select";
            CBoxPower.UseVisualStyleBackColor = true;
            // 
            // CBoxFit
            // 
            CBoxFit.AutoSize = true;
            CBoxFit.CheckAlign = ContentAlignment.TopLeft;
            CBoxFit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxFit.Location = new Point(261, 341);
            CBoxFit.Margin = new Padding(3, 4, 3, 4);
            CBoxFit.Name = "CBoxFit";
            CBoxFit.Size = new Size(88, 32);
            CBoxFit.TabIndex = 44;
            CBoxFit.Text = "Select";
            CBoxFit.UseVisualStyleBackColor = true;
            // 
            // CBoxAerobic
            // 
            CBoxAerobic.AutoSize = true;
            CBoxAerobic.CheckAlign = ContentAlignment.TopLeft;
            CBoxAerobic.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxAerobic.Location = new Point(261, 411);
            CBoxAerobic.Margin = new Padding(3, 4, 3, 4);
            CBoxAerobic.Name = "CBoxAerobic";
            CBoxAerobic.Size = new Size(88, 32);
            CBoxAerobic.TabIndex = 45;
            CBoxAerobic.Text = "Select";
            CBoxAerobic.UseVisualStyleBackColor = true;
            // 
            // CBoxRückenfit
            // 
            CBoxRückenfit.AutoSize = true;
            CBoxRückenfit.CheckAlign = ContentAlignment.TopLeft;
            CBoxRückenfit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBoxRückenfit.Location = new Point(261, 495);
            CBoxRückenfit.Margin = new Padding(3, 4, 3, 4);
            CBoxRückenfit.Name = "CBoxRückenfit";
            CBoxRückenfit.Size = new Size(88, 32);
            CBoxRückenfit.TabIndex = 46;
            CBoxRückenfit.Text = "Select";
            CBoxRückenfit.UseVisualStyleBackColor = true;
            // 
            // KurseWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 707);
            Controls.Add(CBoxRückenfit);
            Controls.Add(CBoxAerobic);
            Controls.Add(CBoxFit);
            Controls.Add(CBoxPower);
            Controls.Add(CBoxStretch);
            Controls.Add(CBoxFuntional);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Ftrbtn);
            Controls.Add(DateLb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAbmelden);
            Controls.Add(BtnAnmelden);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(793, 754);
            MinimumSize = new Size(793, 754);
            Name = "KurseWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kurse";
            Load += KurseWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnmelden;
        private Button BtnAbmelden;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label DateLb;
        private Button Ftrbtn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button2;
        private Label label6;
        private Label label7;
        private CheckBox CBoxFuntional;
        private CheckBox CBoxStretch;
        private CheckBox CBoxPower;
        private CheckBox CBoxFit;
        private CheckBox CBoxAerobic;
        private CheckBox CBoxRückenfit;
    }
}