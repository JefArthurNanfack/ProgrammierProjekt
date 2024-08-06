namespace WeGo_UI
{
    partial class AerobicWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AerobicWinForm));
            BtnReturnStep = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FtLbn = new Label();
            SuspendLayout();
            // 
            // BtnReturnStep
            // 
            BtnReturnStep.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReturnStep.ForeColor = Color.FromArgb(0, 192, 0);
            BtnReturnStep.Location = new Point(688, 748);
            BtnReturnStep.Margin = new Padding(3, 4, 3, 4);
            BtnReturnStep.Name = "BtnReturnStep";
            BtnReturnStep.Size = new Size(110, 49);
            BtnReturnStep.TabIndex = 17;
            BtnReturnStep.Text = "Return";
            BtnReturnStep.UseVisualStyleBackColor = true;
            BtnReturnStep.Click += BtnReturnStep_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(629, 539);
            label6.Name = "label6";
            label6.Size = new Size(282, 84);
            label6.TabIndex = 15;
            label6.Text = "Mondays fron 8 - 9 O'clock\r\n\r\nThursdays fron 19 - 20 O'clock ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(688, 476);
            label5.Name = "label5";
            label5.Size = new Size(162, 37);
            label5.TabIndex = 14;
            label5.Text = "Course Plan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(695, 373);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 13;
            label4.Text = "60 Minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(648, 313);
            label3.Name = "label3";
            label3.Size = new Size(217, 37);
            label3.TabIndex = 12;
            label3.Text = "Course Duration";
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(14, 283);
            label2.Name = "label2";
            label2.Size = new Size(453, 485);
            label2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-7, 81);
            label1.Name = "label1";
            label1.Size = new Size(1101, 148);
            label1.TabIndex = 10;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FtLbn
            // 
            FtLbn.AutoSize = true;
            FtLbn.BackColor = SystemColors.ActiveBorder;
            FtLbn.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FtLbn.Location = new Point(197, 12);
            FtLbn.Name = "FtLbn";
            FtLbn.Size = new Size(699, 44);
            FtLbn.TabIndex = 9;
            FtLbn.Text = "Step Aerobic - Indurance training ";
            // 
            // AerobicWinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(1077, 847);
            Controls.Add(BtnReturnStep);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FtLbn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1095, 894);
            MinimumSize = new Size(1095, 894);
            Name = "AerobicWinForm";
            Text = "Step___Aerobic_Infos";
            Load += AerobicWinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnReturnStep;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label FtLbn;
    }
}