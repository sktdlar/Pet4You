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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pet4You.ChatModule.Components
{
    /// <summary>
    /// Логика взаимодействия для ChatWithUserUC.xaml
    /// </summary>
    public partial class ChatWithUserUC : UserControl
    {
        Chats chat;
        public ChatWithUserUC(Chats _chat)
        {
            InitializeComponent();
            chat = _chat;
            User secondUser = chat.User == App.CurrentUser ? chat.User1 : chat.User;
            NameOfUser.Text = secondUser.Login;
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            Storyboard storyboard = (Storyboard)FindResource("WriteEmailAnimation");
            storyboard.Begin();
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Storyboard storyboard = (Storyboard)FindResource("WriteEmailAnimation");
            storyboard.Stop();
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.ChatPage.ChatFrame.Navigate(new Pages.ChatPage(chat));
        }
    }
}
