namespace WeGo_UI
{
    partial class StretchWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StretchWinform));
            label1 = new Label();
            FtLbn = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnReturnStretch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.Screenshot_2024_05_18_192408;
            label1.Location = new Point(14, 264);
            label1.Name = "label1";
            label1.Size = new Size(446, 459);
            label1.TabIndex = 0;
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(358, 12);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(323, 44);
            FtLbn.TabIndex = 6;
            FtLbn.Text = "Stretch & Relax ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 81);
            label7.Name = "label7";
            label7.Size = new Size(1136, 111);
            label7.TabIndex = 7;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 289);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 8;
            label3.Text = "Course Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(654, 356);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 9;
            label4.Text = "30 – 60 Minutes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(669, 431);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 10;
            label5.Text = "Course Plan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(623, 505);
            label6.Name = "label6";
            label6.Size = new Size(275, 112);
            label6.TabIndex = 11;
            label6.Text = "Tuesdays from 11 - 13 O'clock\r\n\r\nFridays\r\n from 19 - 21 O'clock";
            // 
            // BtnReturnStretch
            // 
            BtnReturnStretch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnStretch.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnStretch.Location = new Point(669, 677);
            BtnReturnStretch.Margin = new Padding(3, 4, 3, 4);
            BtnReturnStretch.Name = "BtnReturnStretch";
            BtnReturnStretch.Size = new Size(110, 45);
            BtnReturnStretch.TabIndex = 48;
            BtnReturnStretch.Text = "Return";
            BtnReturnStretch.UseVisualStyleBackColor = true;
            BtnReturnStretch.Click += BtnReturnStretch_Click;
            // 
            // StretchWinform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1182, 761);
            Controls.Add(BtnReturnStretch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(FtLbn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1200, 808);
            MinimumSize = new Size(1200, 808);
            Name = "StretchWinform";
            Text = "Strecht & Relax Course Infos";
            Load += StretchWinform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label FtLbn;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnReturnStretch;
    }
}