namespace WeGo_UI
{
    partial class Tarifeinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarifeinfo));
            BackBtn = new Button();
            label1 = new Label();
            label = new Label();
            Silberlabel = new Label();
            goldlabel = new Label();
            basiclabel = new Label();
            silberlabel2 = new Label();
            goldlabel3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.ForeColor = Color.Transparent;
            BackBtn.Image = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_262;
            BackBtn.Location = new Point(10, 44);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(36, 34);
            BackBtn.TabIndex = 7;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(74, 44);
            label1.Name = "label1";
            label1.Size = new Size(255, 36);
            label1.TabIndex = 1;
            label1.Text = "Tariff information";
            label1.Click += label1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(0, 192, 0);
            label.Location = new Point(76, 172);
            label.Name = "label";
            label.Size = new Size(75, 29);
            label.TabIndex = 1;
            label.Text = "basic";
            // 
            // Silberlabel
            // 
            Silberlabel.AutoSize = true;
            Silberlabel.BackColor = Color.Transparent;
            Silberlabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Silberlabel.ForeColor = Color.FromArgb(0, 192, 0);
            Silberlabel.Location = new Point(355, 172);
            Silberlabel.Name = "Silberlabel";
            Silberlabel.Size = new Size(80, 29);
            Silberlabel.TabIndex = 2;
            Silberlabel.Text = "Silver";
            // 
            // goldlabel
            // 
            goldlabel.AutoSize = true;
            goldlabel.BackColor = Color.Transparent;
            goldlabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goldlabel.ForeColor = Color.FromArgb(0, 192, 0);
            goldlabel.Location = new Point(594, 170);
            goldlabel.Name = "goldlabel";
            goldlabel.Size = new Size(69, 29);
            goldlabel.TabIndex = 3;
            goldlabel.Text = "Gold";
            // 
            // basiclabel
            // 
            basiclabel.AutoSize = true;
            basiclabel.BackColor = Color.Transparent;
            basiclabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            basiclabel.ForeColor = Color.FromArgb(0, 192, 0);
            basiclabel.Location = new Point(67, 260);
            basiclabel.Name = "basiclabel";
            basiclabel.Size = new Size(190, 140);
            basiclabel.TabIndex = 4;
            basiclabel.Text = "\r\n19,99€ monthly\r\n-no additional service\r\n\r\n\r\n\r\n\r\n";
            basiclabel.Click += basiclabel_Click;
            // 
            // silberlabel2
            // 
            silberlabel2.AutoSize = true;
            silberlabel2.BackColor = Color.Transparent;
            silberlabel2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            silberlabel2.ForeColor = Color.FromArgb(0, 192, 0);
            silberlabel2.Location = new Point(343, 260);
            silberlabel2.Name = "silberlabel2";
            silberlabel2.Size = new Size(141, 60);
            silberlabel2.TabIndex = 5;
            silberlabel2.Text = "24,99 € Monthly\n-Courses\n-Drinks";
            silberlabel2.Click += silberlabel2_Click;
            // 
            // goldlabel3
            // 
            goldlabel3.AutoSize = true;
            goldlabel3.BackColor = Color.Transparent;
            goldlabel3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goldlabel3.ForeColor = Color.FromArgb(0, 192, 0);
            goldlabel3.Location = new Point(594, 260);
            goldlabel3.Name = "goldlabel3";
            goldlabel3.Size = new Size(142, 100);
            goldlabel3.TabIndex = 6;
            goldlabel3.Text = "29.99€\ncourses\ndrinks\npersonal trainer\ngold area";
            goldlabel3.Click += goldlabel3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 124);
            panel1.TabIndex = 8;
            // 
            // Tarifeinfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1249, 678);
            Controls.Add(panel1);
            Controls.Add(goldlabel3);
            Controls.Add(silberlabel2);
            Controls.Add(basiclabel);
            Controls.Add(goldlabel);
            Controls.Add(Silberlabel);
            Controls.Add(label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1267, 725);
            MinimumSize = new Size(1267, 725);
            Name = "Tarifeinfo";
            Text = "Tariff information";
            Load += Tarifeinfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Silberlabel;
        private System.Windows.Forms.Label goldlabel;
        private System.Windows.Forms.Label basiclabel;
        private System.Windows.Forms.Label silberlabel2;
        private System.Windows.Forms.Label goldlabel3;
        private Panel panel1;
    }
}