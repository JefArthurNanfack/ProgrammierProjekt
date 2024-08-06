namespace WeGo_UI
{
    partial class Verwaltungshomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verwaltungshomepage));
            KMBtn = new Button();
            KELBtn = new Button();
            ÜWBtn = new Button();
            SLBtn = new Button();
            panel1 = new Panel();
            Dashboard = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // KMBtn
            // 
            KMBtn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KMBtn.ForeColor = Color.FromArgb(0, 192, 0);
            KMBtn.Location = new Point(11, 162);
            KMBtn.Margin = new Padding(3, 2, 3, 2);
            KMBtn.Name = "KMBtn";
            KMBtn.Size = new Size(176, 52);
            KMBtn.TabIndex = 0;
            KMBtn.Text = "Customer management";
            KMBtn.UseVisualStyleBackColor = true;
            KMBtn.Click += KMBtn_Click;
            // 
            // KELBtn
            // 
            KELBtn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KELBtn.ForeColor = Color.FromArgb(0, 192, 0);
            KELBtn.Location = new Point(11, 231);
            KELBtn.Margin = new Padding(3, 2, 3, 2);
            KELBtn.Name = "KELBtn";
            KELBtn.Size = new Size(176, 52);
            KELBtn.TabIndex = 1;
            KELBtn.Text = "Leading events";
            KELBtn.UseVisualStyleBackColor = true;
            KELBtn.Click += KELBtn_Click;
            // 
            // ÜWBtn
            // 
            ÜWBtn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ÜWBtn.ForeColor = Color.FromArgb(0, 192, 0);
            ÜWBtn.Location = new Point(11, 304);
            ÜWBtn.Margin = new Padding(3, 2, 3, 2);
            ÜWBtn.Name = "ÜWBtn";
            ÜWBtn.Size = new Size(176, 52);
            ÜWBtn.TabIndex = 3;
            ÜWBtn.Text = "surveillance";
            ÜWBtn.UseVisualStyleBackColor = true;
            ÜWBtn.Click += ÜWBtn_Click;
            // 
            // SLBtn
            // 
            SLBtn.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SLBtn.ForeColor = Color.FromArgb(0, 192, 0);
            SLBtn.Location = new Point(11, 372);
            SLBtn.Margin = new Padding(3, 2, 3, 2);
            SLBtn.Name = "SLBtn";
            SLBtn.Size = new Size(176, 52);
            SLBtn.TabIndex = 4;
            SLBtn.Text = "Provide support";
            SLBtn.UseVisualStyleBackColor = true;
            SLBtn.Click += SLBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(Dashboard);
            panel1.Location = new Point(0, -2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 124);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // Dashboard
            // 
            Dashboard.AutoSize = true;
            Dashboard.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.FromArgb(0, 192, 0);
            Dashboard.Location = new Point(11, 42);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(208, 45);
            Dashboard.TabIndex = 6;
            Dashboard.Text = "Dashboard";
            // 
            // Verwaltungshomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_07_17_at_20_18_12;
            ClientSize = new Size(972, 450);
            Controls.Add(panel1);
            Controls.Add(SLBtn);
            Controls.Add(ÜWBtn);
            Controls.Add(KELBtn);
            Controls.Add(KMBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Verwaltungshomepage";
            Text = "Administration homepage";
            Load += Verwaltungshomepage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button KMBtn;
        private System.Windows.Forms.Button KELBtn;
        private System.Windows.Forms.Button ÜWBtn;
        private System.Windows.Forms.Button SLBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Dashboard;
    }
}