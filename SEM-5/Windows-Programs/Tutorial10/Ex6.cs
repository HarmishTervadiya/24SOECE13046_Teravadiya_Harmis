using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Tutorial10
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }
      
        private void SendEmail(string from, string to, string message)
        {
            
            string senderEmail = "harmistervadiya@gmail.com";
            string appPassword = "rpdtuggbxdwjcxdd"; 

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, appPassword)
            };

            smtp.EnableSsl = true; 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail); 
            mail.To.Add(to);
            mail.Subject = "Email from WinForms App";
            mail.Body = message;
            smtp.Send(mail);
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFrom.Text))
            {
                MessageBox.Show("Please enter From email");
                return;
            }

            if (string.IsNullOrEmpty(txtTo.Text))
            {
                MessageBox.Show("Please enter To email");
                return;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please enter Message");
                return;
            }

            try
            {
                SendEmail(txtFrom.Text, txtTo.Text, txtMessage.Text);

                MessageBox.Show("Email sent successfully!", "Success");

                txtFrom.Clear();
                txtTo.Clear();
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }
    }
}
