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
using System.Data.Sql;
using System.Data.SqlClient;


namespace EmailClient
{
    public partial class Form1 : Form
    {
      //  NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        //string strConnection=@"Data Source=HP\SQLEXPRESS; Initial Catalog=Login; Integrated Security=True";
        //SqlConnection conn;
        //SqlCommand command;
        public static TextBox tb = new TextBox();
        public static TextBox tb1 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }
       private void btnLogin_Click(object sender, EventArgs e)
        {
           Main Main = new Main();
            if (txtUsername.Text == "quandt2191@gmail.com" && txtPassword.Text == "160621qtq") 
            {
                this.Hide();
                Main.Show();
            }
           else
           {
               MessageBox.Show(" sai Username hoặc Password, xin mời nhập lại");
           }
           //SmtpClient client = new SmtpClient(txtSmtp.Text);
       //    login=new NetworkCredential(txtUsername.Text,txtPassword.Text);
           //client=new SmtpClient(txtSmtp.Text);
           //client.Port=Convert.ToInt32(txtPort.Text);
          
           //client.Credentials=new System.Net.NetworkCredential(txtUsername.Text,txtPassword);
          //  client.EnableSsl=true;
          SmtpClient client=new SmtpClient(txtSmtp.Text);
                client.Port=587;
                client.Credentials=new System.Net.NetworkCredential(txtUsername.Text,txtPassword.Text);
                client.EnableSsl=true;
                //client.Send();
          /* If (reader.Read()==true), 

                { 
                this.Hide();
                From Main=new Main();
                Main.Show();
                }
                Else
                {
                MessageBox.Show(“ban dang nhap khong thanh cong”);
                txtUsername.Text=””;
                txtUsername.Text=””;
                txtUsername.Focus();
                }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = txtUsername;
            tb1 = txtPassword;
        }

    }
}
