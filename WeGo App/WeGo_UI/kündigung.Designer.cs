
namespace WeGo_UI
{
    partial class kündigung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kündigung));
            textBox1 = new TextBox();
            kdlabel = new Label();
            panel1 = new Panel();
            BackBtn = new Button();
            kunlabel = new Label();
            kdbtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 261);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 1;
            // 
            // kdlabel
            // 
            kdlabel.AutoSize = true;
            kdlabel.BackColor = SystemColors.ControlText;
            kdlabel.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kdlabel.ForeColor = Color.FromArgb(0, 192, 0);
            kdlabel.Location = new Point(73, 42);
            kdlabel.Name = "kdlabel";
            kdlabel.Size = new Size(188, 38);
            kdlabel.TabIndex = 2;
            kdlabel.Text = "Termination";
            kdlabel.Click += kdlabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(kdlabel);
            panel1.Location = new Point(-8, -2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 118);
            panel1.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.ForeColor = Color.Transparent;
            BackBtn.Image = Properties.Resources.BackBtn;
            BackBtn.Location = new Point(19, 47);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(29, 31);
            BackBtn.TabIndex = 4;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // kunlabel
            // 
            kunlabel.AutoSize = true;
            kunlabel.BackColor = Color.Transparent;
            kunlabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kunlabel.ForeColor = Color.FromArgb(0, 192, 0);
            kunlabel.Location = new Point(65, 261);
            kunlabel.Name = "kunlabel";
            kunlabel.Size = new Size(110, 16);
            kunlabel.TabIndex = 4;
            kunlabel.Text = "Termination id ";
            // 
            // kdbtn
            // 
            kdbtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kdbtn.ForeColor = Color.FromArgb(0, 192, 0);
            kdbtn.Location = new Point(344, 372);
            kdbtn.Margin = new Padding(3, 4, 3, 4);
            kdbtn.Name = "kdbtn";
            kdbtn.Size = new Size(101, 40);
            kdbtn.TabIndex = 6;
            kdbtn.Text = "Termination";
            kdbtn.UseVisualStyleBackColor = true;
            kdbtn.Click += kdbtn_Click;
            // 
            // kündigung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1205, 916);
            Controls.Add(kdbtn);
            Controls.Add(kunlabel);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1223, 963);
            MinimumSize = new Size(1223, 963);
            Name = "kündigung";
            Text = "kündigung";
            Load += kündigung_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kdlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kunlabel;
        private System.Windows.Forms.Button kdbtn;
        private System.Windows.Forms.Button BackBtn;
    }
}