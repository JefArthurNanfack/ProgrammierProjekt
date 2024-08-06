namespace WeGo_UI
{
    partial class PowerWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerWinForm));
            FtLbn = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            BtnReturnPower = new Button();
            SuspendLayout();
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(328, 32);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(338, 44);
            FtLbn.TabIndex = 7;
            FtLbn.Text = "Power Workout ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 105);
            label7.Name = "label7";
            label7.Size = new Size(959, 74);
            label7.TabIndex = 8;
            label7.Text = "A high-intensity workout to strengthen and tone the muscles of the entire body.\r\nCombination of cardiovascular training and strength endurance training.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(613, 511);
            label6.Name = "label6";
            label6.Size = new Size(280, 84);
            label6.TabIndex = 18;
            label6.Text = "Wednesdays fron 8 - 9 O'Clock\r\n\r\nFridays from 20 - 21 O'clock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(658, 436);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 17;
            label5.Text = "Course Plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(659, 368);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 16;
            label4.Text = "30  Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 295);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 15;
            label3.Text = "Course Duration";
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(3, 269);
            label1.Name = "label1";
            label1.Size = new Size(451, 459);
            label1.TabIndex = 14;
            // 
            // BtnReturnPower
            // 
            BtnReturnPower.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnPower.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnPower.Location = new Point(658, 717);
            BtnReturnPower.Margin = new Padding(3, 4, 3, 4);
            BtnReturnPower.Name = "BtnReturnPower";
            BtnReturnPower.Size = new Size(110, 49);
            BtnReturnPower.TabIndex = 20;
            BtnReturnPower.Text = "Return";
            BtnReturnPower.UseVisualStyleBackColor = true;
            BtnReturnPower.Click += BtnReturnPower_Click;
            // 
            // PowerWinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1016, 800);
            Controls.Add(BtnReturnPower);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(FtLbn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "PowerWinForm";
            Text = "Power_Workout_Infos";
            Load += PowerWinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FtLbn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button BtnReturnPower;
    }
}