using Pet4You.ChatModule.Components;
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

namespace Pet4You.ChatModule.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChattingModulePage.xaml
    /// </summary>
    public partial class ChattingModulePage : Page
    {
        public ChattingModulePage()
        {
            InitializeComponent();
            App.ChatPage = this;
            RefreshChats();
        }
        void RefreshChats()
        {
            ChatsWP.Children.Clear();
            foreach(var chat in App.db.Chats.ToList().Where(x => x.User1Id == App.CurrentUser.Id || x.User2Id == App.CurrentUser.Id))
            {
                ChatsWP.Children.Add(new ChatWithUserUC(chat));
            }
        }
    }
}
