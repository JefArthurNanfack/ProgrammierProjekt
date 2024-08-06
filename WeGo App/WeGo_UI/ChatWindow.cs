using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace WeGo_UI
{
    public partial class ChatWindow : Form
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text.Trim();
            string subject = subjectTextBox.Text.Trim();
            string recipientEmail = recipientTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(subject) && !string.IsNullOrEmpty(recipientEmail))
            {
                try
                {
                    SendEmail(recipientEmail, subject, message);
                    MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all fields before sending.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SendEmail(string recipientEmail, string subject, string message)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("wegogymtime@gmail.com", "yphr eews chee hdyp"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("wegogymtime@gmail.com"),
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(recipientEmail);

            smtpClient.Send(mailMessage);
        }

        private void ChatWindow_Load(object sender, EventArgs e)
        {

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}