using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class Form2 : Form
    {
        string emailList;
        public Form2(string emailList)
        {
            InitializeComponent();
            this.emailList = emailList;
        }

        private void emailSendButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (emailEnterTextBox.Text == "")
                {
                    MessageBox.Show("Geben Sie eine E-Mailadresse ein!");
                }
                else if (emailSubjectTextBox.Text == "")
                {
                    MessageBox.Show("Geben Sie ein Betreff ein!");
                }
                else
                {
                    string addMail = emailEnterTextBox.Text;
                    string subject = emailSubjectTextBox.Text;
                    string body = emailTextRichTextBox.Text + "\n\n\n";

                    List<string> emailRows = emailList.Split('/').ToList();
                    foreach (string emailRow in emailRows)
                    {
                        body += emailRow.Replace('|', ' ') + "\n";
                    }

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("SwissTranslationProjekt@gmail.com");
                    mail.To.Add(addMail);
                    mail.Subject = subject;
                    mail.Body = body;
                    body +=

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("SwissTranslationProjekt@gmail.com", "swisstranslation_123");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");


                    emailEnterTextBox.Text = "";
                    emailSubjectTextBox.Text = "";
                    emailTextRichTextBox.Text = "";
                }
            }
            catch { }
        }
    }
}
