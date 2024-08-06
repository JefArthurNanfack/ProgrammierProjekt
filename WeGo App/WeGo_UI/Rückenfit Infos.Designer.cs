namespace WeGo_UI
{
    partial class RückenfitWinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RückenfitWinform));
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label7 = new Label();
            FtLbn = new Label();
            BtnReturnRück = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(685, 624);
            label6.Name = "label6";
            label6.Size = new Size(282, 56);
            label6.TabIndex = 45;
            label6.Text = "Thursdays fron 20 - 22 O'clock \r\nFridays from 8 - 10 O'clock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(730, 548);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 44;
            label5.Text = "Course Plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(731, 480);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 43;
            label4.Text = "60 Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(685, 407);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 42;
            label3.Text = "Course Duration";
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(40, 343);
            label1.Name = "label1";
            label1.Size = new Size(451, 525);
            label1.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(119, 119);
            label7.Name = "label7";
            label7.Size = new Size(765, 148);
            label7.TabIndex = 40;
            label7.Text = resources.GetString("label7.Text");
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(353, 35);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(363, 44);
            FtLbn.TabIndex = 39;
            FtLbn.Text = "Rückenfit Kurse ";
            // 
            // BtnReturnRück
            // 
            BtnReturnRück.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnRück.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnRück.Location = new Point(731, 837);
            BtnReturnRück.Margin = new Padding(3, 4, 3, 4);
            BtnReturnRück.Name = "BtnReturnRück";
            BtnReturnRück.Size = new Size(110, 45);
            BtnReturnRück.TabIndex = 47;
            BtnReturnRück.Text = "Return";
            BtnReturnRück.UseVisualStyleBackColor = true;
            BtnReturnRück.Click += BtnReturnRück_Click;
            // 
            // RückenfitWinform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1127, 964);
            Controls.Add(BtnReturnRück);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(FtLbn);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1145, 1011);
            MinimumSize = new Size(1145, 1011);
            Name = "RückenfitWinform";
            Text = "Rückenfit_Infos";
            Load += RückenfitWinform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label7;
        private Label FtLbn;
        private Button BtnReturnRück;
    }
}