namespace WeGo_UI
{
    partial class Kundenmanagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kundenmanagement));
            panel1 = new Panel();
            BackBtn = new Button();
            KManagement = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Nkbtn = new Button();
            Kdbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(KManagement);
            panel1.Location = new Point(-2, 1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 141);
            panel1.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.Image = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_264;
            BackBtn.Location = new Point(14, 52);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(29, 31);
            BackBtn.TabIndex = 3;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // KManagement
            // 
            KManagement.AutoSize = true;
            KManagement.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KManagement.ForeColor = Color.FromArgb(0, 192, 0);
            KManagement.Location = new Point(57, 48);
            KManagement.Name = "KManagement";
            KManagement.Size = new Size(371, 39);
            KManagement.TabIndex = 0;
            KManagement.Text = "Customer management";
            // 
            // Nkbtn
            // 
            Nkbtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nkbtn.ForeColor = Color.FromArgb(0, 192, 0);
            Nkbtn.Location = new Point(44, 212);
            Nkbtn.Margin = new Padding(3, 4, 3, 4);
            Nkbtn.Name = "Nkbtn";
            Nkbtn.Size = new Size(107, 60);
            Nkbtn.TabIndex = 1;
            Nkbtn.Text = "New Customer";
            Nkbtn.UseVisualStyleBackColor = true;
            Nkbtn.Click += Nkbtn_Click;
            // 
            // Kdbtn
            // 
            Kdbtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kdbtn.ForeColor = Color.FromArgb(0, 192, 0);
            Kdbtn.Location = new Point(44, 325);
            Kdbtn.Margin = new Padding(3, 4, 3, 4);
            Kdbtn.Name = "Kdbtn";
            Kdbtn.Size = new Size(107, 59);
            Kdbtn.TabIndex = 2;
            Kdbtn.Text = "Termination";
            Kdbtn.UseVisualStyleBackColor = true;
            Kdbtn.Click += Kdbtn_Click;
            // 
            // Kundenmanagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_184;
            ClientSize = new Size(1122, 615);
            Controls.Add(Kdbtn);
            Controls.Add(Nkbtn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kundenmanagement";
            Text = "Customer management";
            Load += Kundenmanagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KManagement;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Nkbtn;
        private System.Windows.Forms.Button Kdbtn;
        private System.Windows.Forms.Button BackBtn;
    }
}