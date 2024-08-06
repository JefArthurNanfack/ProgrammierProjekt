namespace WeGo_UI
{
    partial class SupportLeisten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportLeisten));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fragen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AtBox = new System.Windows.Forms.RichTextBox();
            this.Sdbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 116);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::WeGo_UI.Properties.Resources.Screenshot_2024_06_05_215041;
            this.BackBtn.Location = new System.Drawing.Point(5, 42);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(29, 25);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Support Ableitung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fragen
            // 
            this.fragen.FormattingEnabled = true;
            this.fragen.ItemHeight = 16;
            this.fragen.Location = new System.Drawing.Point(70, 166);
            this.fragen.Name = "fragen";
            this.fragen.Size = new System.Drawing.Size(272, 100);
            this.fragen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 3;
            // 
            // AtBox
            // 
            this.AtBox.Location = new System.Drawing.Point(70, 304);
            this.AtBox.Name = "AtBox";
            this.AtBox.Size = new System.Drawing.Size(272, 96);
            this.AtBox.TabIndex = 4;
            this.AtBox.Text = "Antwort";
            // 
            // Sdbtn
            // 
            this.Sdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdbtn.Location = new System.Drawing.Point(70, 438);
            this.Sdbtn.Name = "Sdbtn";
            this.Sdbtn.Size = new System.Drawing.Size(95, 37);
            this.Sdbtn.TabIndex = 5;
            this.Sdbtn.Text = "Send";
            this.Sdbtn.UseVisualStyleBackColor = true;
            // 
            // SupportLeisten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeGo_UI.Properties.Resources.Screenshot_2024_06_05_215041;
            this.ClientSize = new System.Drawing.Size(1197, 786);
            this.Controls.Add(this.Sdbtn);
            this.Controls.Add(this.AtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fragen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SupportLeisten";
            this.Text = "Support Leisten";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fragen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox AtBox;
        private System.Windows.Forms.Button Sdbtn;
        private System.Windows.Forms.Button BackBtn;
    }
}