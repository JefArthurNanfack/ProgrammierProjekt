namespace WeGo_UI
{
    partial class FtnTrn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtnTrn));
            FtLbn = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnReturnFun = new Button();
            SuspendLayout();
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(6, 39);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(1000, 44);
            FtLbn.TabIndex = 0;
            FtLbn.Text = "Functional Training Course-Whole-Body-Workout ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 97);
            label1.Name = "label1";
            label1.Size = new Size(830, 148);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(14, 276);
            label2.Name = "label2";
            label2.Size = new Size(376, 485);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 289);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 3;
            label3.Text = "Course Duration";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(557, 359);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 4;
            label4.Text = "45 – 60 Minutes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(568, 452);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 5;
            label5.Text = "Course Plan";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(509, 515);
            label6.Name = "label6";
            label6.Size = new Size(282, 84);
            label6.TabIndex = 6;
            label6.Text = "Mondays fron 8 - 9 O'clock\r\n\r\nThursdays fron 19 - 20 O'clock ";
            // 
            // BtnReturnFun
            // 
            BtnReturnFun.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnFun.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnFun.Location = new Point(598, 686);
            BtnReturnFun.Margin = new Padding(3, 4, 3, 4);
            BtnReturnFun.Name = "BtnReturnFun";
            BtnReturnFun.Size = new Size(110, 51);
            BtnReturnFun.TabIndex = 8;
            BtnReturnFun.Text = "Return";
            BtnReturnFun.UseVisualStyleBackColor = true;
            BtnReturnFun.Click += BtnReturnFun_Click;
            // 
            // FtnTrn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 791);
            Controls.Add(BtnReturnFun);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FtLbn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FtnTrn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funtional Training Features";
            Load += Funtional_Training_Features_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FtLbn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnReturnFun;
    }
}