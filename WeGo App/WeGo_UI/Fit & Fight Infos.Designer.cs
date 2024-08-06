namespace WeGo_UI
{
    partial class FitWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitWinForm));
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            FtLbn = new Label();
            BtnReturnFit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 639);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(653, 520);
            label6.Name = "label6";
            label6.Size = new Size(242, 84);
            label6.TabIndex = 27;
            label6.Text = "Montags von 20 - 22 Uhr\r\n\r\nSamstags von 18 - 20 Uhr ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(698, 444);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 26;
            label5.Text = "Course plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(699, 376);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 25;
            label4.Text = "60 Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(653, 303);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 24;
            label3.Text = "Course Duration";
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(14, 205);
            label1.Name = "label1";
            label1.Size = new Size(451, 531);
            label1.TabIndex = 23;
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(86, 72);
            label7.Name = "label7";
            label7.Size = new Size(858, 111);
            label7.TabIndex = 22;
            label7.Text = "The Fit & Fight course is a full-body workout that combines \r\nelements of cardio with martial arts techniques. \r\nThe varied punch and kick combinations increase mobility and stamina.";
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(126, 12);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(799, 44);
            FtLbn.TabIndex = 21;
            FtLbn.Text = "Fit & Fight Course - Whole Body Workout ";
            // 
            // BtnReturnFit
            // 
            BtnReturnFit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnFit.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnFit.Location = new Point(698, 727);
            BtnReturnFit.Margin = new Padding(3, 4, 3, 4);
            BtnReturnFit.Name = "BtnReturnFit";
            BtnReturnFit.Size = new Size(110, 48);
            BtnReturnFit.TabIndex = 29;
            BtnReturnFit.Text = "Return";
            BtnReturnFit.UseVisualStyleBackColor = true;
            BtnReturnFit.Click += BtnReturnFit_Click;
            // 
            // FitWinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1034, 819);
            Controls.Add(BtnReturnFit);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(FtLbn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1052, 866);
            MinimumSize = new Size(1052, 866);
            Name = "FitWinForm";
            Text = "Fit Fight Infos";
            Load += FitWinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label FtLbn;
        private Button BtnReturnFit;
    }
}