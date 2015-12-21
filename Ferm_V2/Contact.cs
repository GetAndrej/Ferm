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

namespace Ferm_V2
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        public void Message1() {
            MailMessage ma = new MailMessage();
            ma.To.Add("andrii.zhadan@nure.ua");
            ma.From = new MailAddress("andrii.zhadan@nure.ua");
            ma.Subject = "Theme:" + textBox3;
            ma.Body = "Name:" + textBox1.Text +
                "<br><br>" +
                "Email:" + textBox2.Text +
                "<br><br>" +
                "Message:" + textBox4.Text;
            ma.IsBodyHtml = true;


            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("andrii.zhadan@nure.ua","zaraza16");

            smtp.Send(ma);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message1();
            Hide();
        }

      //  private class NetworkCredentials : ICredentialsByHost
        //{
          //  private string v1;
            //private string v2;

//            public NetworkCredentials(string v1, string v2)
  //          {
    //            this.v1 = v1;
      //          this.v2 = v2;
        //    }

          //  public NetworkCredential GetCredential(string host, int port, string authenticationType)
           // {
             //   throw new NotImplementedException();
            //}
        //}
    }
}
