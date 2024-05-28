using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pet4You.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        int code = 0;
        private void SendCodeBtn_Click(object sender, RoutedEventArgs e)
        {
            MailAddress toAddress = new MailAddress(EmailTb.Text);
            MailAddress fromAddress = new MailAddress("burtovdanil2005@yandex.ru");
            MailMessage message = new MailMessage(fromAddress, toAddress);
            Random random = new Random();
            code = random.Next(1000, 10000);
            message.Body = code.ToString();
            message.Subject = "no:reply|Код для входа в приложение";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.yandex.ru";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("burtovdanil2005@yandex.ru", "apfrqmsqkawgbikb");
            smtpClient.Send(message);
            EnterCode.Visibility = Visibility.Collapsed;
            ApplyCode.Visibility = Visibility.Visible;
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            if (CodeTb.Text == code.ToString())
            {
                MessageBox.Show("Успешный вход!");
            }
        }
    }
}