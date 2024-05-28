using Pet4You.Components;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Pet4You.ChatModule.Components
{
    /// <summary>
    /// Логика взаимодействия для MessageUC.xaml
    /// </summary>
    public partial class MessageUC : UserControl
    {
        public MessageUC(Messages message)
        {
            InitializeComponent();
            MessageText.Text = message.MessageText;
            if(message.User == App.CurrentUser)
            {
                MailTB.Text = "Вы";
            }
            else
            {
                MailTB.Text = message.User.Login;
            }
            Timestamp.Text = message.Timestamp.ToString();
        }
    }
}
