namespace WeGo_UI
{
    partial class WorkoutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkoutWindow));
            CardioBx = new CheckBox();
            BulkingBx = new CheckBox();
            CuttingBx = new CheckBox();
            HomeCBx = new CheckBox();
            calisthenicsBx = new CheckBox();
            HomeBx = new CheckBox();
            richTextBox1 = new RichTextBox();
            CreateBtn = new Button();
            SuspendLayout();
            // 
            // CardioBx
            // 
            CardioBx.AutoSize = true;
            CardioBx.Location = new Point(84, 35);
            CardioBx.Name = "CardioBx";
            CardioBx.Size = new Size(75, 24);
            CardioBx.TabIndex = 0;
            CardioBx.Text = "Cardio";
            CardioBx.UseVisualStyleBackColor = true;
            CardioBx.CheckedChanged += CardioBx_CheckedChanged;
            // 
            // BulkingBx
            // 
            BulkingBx.AutoSize = true;
            BulkingBx.Location = new Point(345, 35);
            BulkingBx.Name = "BulkingBx";
            BulkingBx.Size = new Size(80, 24);
            BulkingBx.TabIndex = 1;
            BulkingBx.Text = "Bulking";
            BulkingBx.UseVisualStyleBackColor = true;
            BulkingBx.CheckedChanged += BulkingBx_CheckedChanged;
            // 
            // CuttingBx
            // 
            CuttingBx.AutoSize = true;
            CuttingBx.Location = new Point(644, 35);
            CuttingBx.Name = "CuttingBx";
            CuttingBx.Size = new Size(79, 24);
            CuttingBx.TabIndex = 2;
            CuttingBx.Text = "Cutting";
            CuttingBx.UseVisualStyleBackColor = true;
            CuttingBx.CheckedChanged += CuttingBx_CheckedChanged;
            // 
            // HomeCBx
            // 
            HomeCBx.AutoSize = true;
            HomeCBx.Enabled = false;
            HomeCBx.Location = new Point(84, 144);
            HomeCBx.Name = "HomeCBx";
            HomeCBx.Size = new Size(75, 24);
            HomeCBx.TabIndex = 3;
            HomeCBx.Text = "Cardio";
            HomeCBx.UseVisualStyleBackColor = true;
            HomeCBx.Visible = false;
            HomeCBx.CheckedChanged += HomeCBx_CheckedChanged;
            // 
            // calisthenicsBx
            // 
            calisthenicsBx.AutoSize = true;
            calisthenicsBx.Enabled = false;
            calisthenicsBx.Location = new Point(345, 144);
            calisthenicsBx.Name = "calisthenicsBx";
            calisthenicsBx.Size = new Size(108, 24);
            calisthenicsBx.TabIndex = 4;
            calisthenicsBx.Text = "Calisthenics";
            calisthenicsBx.UseVisualStyleBackColor = true;
            calisthenicsBx.Visible = false;
            calisthenicsBx.CheckedChanged += calisthenicsBx_CheckedChanged;
            // 
            // HomeBx
            // 
            HomeBx.AutoSize = true;
            HomeBx.Location = new Point(345, 90);
            HomeBx.Name = "HomeBx";
            HomeBx.Size = new Size(140, 24);
            HomeBx.TabIndex = 7;
            HomeBx.Text = "Home Training ?";
            HomeBx.UseVisualStyleBackColor = true;
            HomeBx.CheckedChanged += HomeBx_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(86, 264);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(639, 156);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(181, 229);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(428, 29);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "Create Plan";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // WorkoutWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(CreateBtn);
            Controls.Add(richTextBox1);
            Controls.Add(HomeBx);
            Controls.Add(calisthenicsBx);
            Controls.Add(HomeCBx);
            Controls.Add(CuttingBx);
            Controls.Add(BulkingBx);
            Controls.Add(CardioBx);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "WorkoutWindow";
            Text = "Workout Plans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox CardioBx;
        private CheckBox BulkingBx;
        private CheckBox CuttingBx;
        private CheckBox HomeCBx;
        private CheckBox calisthenicsBx;
        private CheckBox HomeBx;
        private RichTextBox richTextBox1;
        private Button CreateBtn;
    }
}