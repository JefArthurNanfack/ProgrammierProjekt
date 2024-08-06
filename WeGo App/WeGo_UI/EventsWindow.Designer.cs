namespace WeGo_UI
{
    partial class EventsWindow
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
            EventsBx = new RichTextBox();
            RefreshBtn = new Button();
            SuspendLayout();
            // 
            // EventsBx
            // 
            EventsBx.Location = new Point(12, 132);
            EventsBx.Name = "EventsBx";
            EventsBx.ReadOnly = true;
            EventsBx.Size = new Size(781, 257);
            EventsBx.TabIndex = 0;
            EventsBx.Text = "";
            EventsBx.TextChanged += EventsBx_TextChanged;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = SystemColors.ActiveCaption;
            RefreshBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RefreshBtn.Location = new Point(338, 84);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(119, 42);
            RefreshBtn.TabIndex = 1;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // EventsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hvDJo_9F1;
            ClientSize = new Size(833, 792);
            Controls.Add(RefreshBtn);
            Controls.Add(EventsBx);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(851, 839);
            MinimumSize = new Size(851, 839);
            Name = "EventsWindow";
            Text = "Events";
            Load += EventsWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox EventsBx;
        private Button RefreshBtn;
    }
}