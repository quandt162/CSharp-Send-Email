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

namespace EmailClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    SmtpClient client = new SmtpClient("smtp.gmail.com", 465);
            //    client.Credentials = new NetworkCredential(Form1.tb.Text, Form1.tb1.Text);
            //    MailMessage msg = new MailMessage();
            //    msg.To.Add(new MailAddress(txtTo.Text));
            //    msg.From = new MailAddress(txtFrom.Text);
            //    msg.Subject = txtSubject.Text;
            //    msg.Body = txtBody.Text;
            //    client.EnableSsl = true;
            //    client.Send(msg);


            //}
            //catch
            //{
            //    MessageBox.Show("Sorry", "Error");
            //}



            MailAddress fromAddress = new MailAddress(Form1.tb.Text, "From Name");
            MailAddress toAddress = new MailAddress(txtTo.Text, "To Name");
            string fromPassword = Form1.tb1.Text;
            string subject = txtSubject.Text;
            string body = txtBody.Text;

            //khai báo SmtpClient
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            // truyền tham số cho message
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            //gửi mail
            {
                smtp.Send(message);
                MessageBox.Show("Gửi Thành Công!");
            }

        }

      
    }
}
