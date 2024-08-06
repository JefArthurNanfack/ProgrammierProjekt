namespace WeGo_UI
{
    partial class ErnährungWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErnährungWindow));
            CutBtn = new Button();
            BulkBtn = new Button();
            FoodListV = new RichTextBox();
            AgeBx = new TextBox();
            HeightBx = new TextBox();
            WeightBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // CutBtn
            // 
            CutBtn.BackColor = SystemColors.ActiveCaption;
            CutBtn.Location = new Point(463, 242);
            CutBtn.Name = "CutBtn";
            CutBtn.Size = new Size(94, 127);
            CutBtn.TabIndex = 0;
            CutBtn.Text = "CUT";
            CutBtn.UseVisualStyleBackColor = false;
            CutBtn.Click += CutBtn_Click;
            // 
            // BulkBtn
            // 
            BulkBtn.BackColor = SystemColors.ActiveCaption;
            BulkBtn.Location = new Point(463, 98);
            BulkBtn.Name = "BulkBtn";
            BulkBtn.Size = new Size(94, 122);
            BulkBtn.TabIndex = 1;
            BulkBtn.Text = "BULK";
            BulkBtn.UseVisualStyleBackColor = false;
            BulkBtn.Click += BulkBtn_Click;
            // 
            // FoodListV
            // 
            FoodListV.Location = new Point(12, 28);
            FoodListV.Name = "FoodListV";
            FoodListV.ReadOnly = true;
            FoodListV.Size = new Size(287, 397);
            FoodListV.TabIndex = 2;
            FoodListV.Text = "";
            FoodListV.TextChanged += FoodListV_TextChanged;
            // 
            // AgeBx
            // 
            AgeBx.Location = new Point(309, 125);
            AgeBx.Name = "AgeBx";
            AgeBx.Size = new Size(125, 27);
            AgeBx.TabIndex = 3;
            AgeBx.TextChanged += AgeBx_TextChanged;
            // 
            // HeightBx
            // 
            HeightBx.Location = new Point(309, 223);
            HeightBx.Name = "HeightBx";
            HeightBx.Size = new Size(125, 27);
            HeightBx.TabIndex = 4;
            HeightBx.TextChanged += HeightBx_TextChanged;
            // 
            // WeightBx
            // 
            WeightBx.Location = new Point(309, 318);
            WeightBx.Name = "WeightBx";
            WeightBx.Size = new Size(125, 27);
            WeightBx.TabIndex = 5;
            WeightBx.TextChanged += WeightBx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 102);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 6;
            label1.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 200);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 7;
            label2.Text = "Height  (cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 295);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Weight  (kg)";
            // 
            // ErnährungWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WeightBx);
            Controls.Add(HeightBx);
            Controls.Add(AgeBx);
            Controls.Add(FoodListV);
            Controls.Add(BulkBtn);
            Controls.Add(CutBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "ErnährungWindow";
            Text = "Food Plans";
            Load += ErnährungWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CutBtn;
        private Button BulkBtn;
        private RichTextBox FoodListV;
        private TextBox AgeBx;
        private TextBox HeightBx;
        private TextBox WeightBx;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}