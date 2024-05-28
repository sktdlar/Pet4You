using Pet4You.ChatModule.Components;
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
using System.Windows.Threading;

namespace Pet4You.ChatModule.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChatPage.xaml
    /// </summary>
    public partial class ChatPage : Page
    {
        Chats chat;
        public ChatPage(Chats _chat)
        {
            InitializeComponent();
            chat = _chat;
            User secondUser = chat.User == App.CurrentUser ? chat.User1 : chat.User;
            UserMail.Content = secondUser.Login;
            Refresh();
            ScrollSV.ScrollToEnd();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        void Refresh()
        {
            MessagesWp.Children.Clear();
            foreach (var item in App.db.Messages.ToList().Where(x => x.Chats == chat).OrderBy(x => x.Timestamp))
            {
                MessagesWp.Children.Add(new MessageUC(item));
            }
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            App.db.Messages.Add(new Messages
            {
                ChatId = chat.id,
                MessageText = Message.Text,
                SenderId = App.CurrentUser.Id,
                Timestamp = DateTime.Now,
            });
            App.db.SaveChanges();
            Refresh();
            Message.Text = "";
        }
    }
}
