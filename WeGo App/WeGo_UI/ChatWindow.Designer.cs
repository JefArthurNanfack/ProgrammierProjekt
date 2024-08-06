namespace WeGo_UI
{
    partial class ChatWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox recipientTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label labelRecipient;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            messageTextBox = new TextBox();
            subjectTextBox = new TextBox();
            recipientTextBox = new TextBox();
            sendButton = new Button();
            labelRecipient = new Label();
            labelSubject = new Label();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 113);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(360, 100);
            messageTextBox.TabIndex = 2;
            messageTextBox.TextChanged += messageTextBox_TextChanged;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(12, 71);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(360, 27);
            subjectTextBox.TabIndex = 1;
            // 
            // recipientTextBox
            // 
            recipientTextBox.Location = new Point(12, 29);
            recipientTextBox.Name = "recipientTextBox";
            recipientTextBox.Size = new Size(360, 27);
            recipientTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(297, 219);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(75, 23);
            sendButton.TabIndex = 3;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // labelRecipient
            // 
            labelRecipient.AutoSize = true;
            labelRecipient.Location = new Point(12, 9);
            labelRecipient.Name = "labelRecipient";
            labelRecipient.Size = new Size(71, 20);
            labelRecipient.TabIndex = 4;
            labelRecipient.Text = "Recipient";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(12, 51);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(58, 20);
            labelSubject.TabIndex = 5;
            labelSubject.Text = "Subject";
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(12, 93);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(67, 20);
            labelMessage.TabIndex = 6;
            labelMessage.Text = "Message";
            // 
            // ChatWindow
            // 
            ClientSize = new Size(384, 261);
            Controls.Add(labelMessage);
            Controls.Add(labelSubject);
            Controls.Add(labelRecipient);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(subjectTextBox);
            Controls.Add(recipientTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(402, 308);
            MinimumSize = new Size(402, 308);
            Name = "ChatWindow";
            Text = "Send Email";
            Load += ChatWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
