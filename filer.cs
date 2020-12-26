using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         try
         {
                    MailMessage mail = new MailMessage();
                    // Specify main SMTP server
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    //sender
                    mail.From = new MailAddress("test@gmail.com");
                    // receiver
                    mail.To.Add("receiver@gmail.com");
                    //suject of the mail
                    mail.Subject = "Subject";
                    //content of the mail
                    mail.Body = "Hello!";
                    //tcp port
                    SmtpServer.Port =587;
                    //authentication username ,passeword
                    SmtpServer.Credentials = new System.Net.NetworkCredential("test@gmail.com", "*************");
                    // Enable ssl encryption 
                    SmtpServer.EnableSsl = true;
                    //send mail
                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");
           }
               //if the message has not been sent
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
