using System;
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

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
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

                    smtp.Credentials = new NetworkCredential("andrii.zhadan@nure.ua", "zaraza16");

                    smtp.Send(ma);
                    Close();
                }
                catch {
                    MessageBox.Show("Сообщение не отправлено. Проверьте интернет соединение!");
                }
            }
            else {
                MessageBox.Show("Не все поля заполнены.");
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message1();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
