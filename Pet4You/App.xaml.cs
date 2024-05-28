using Pet4You.ChatModule.Components;
using Pet4You.ChatModule.Pages;
using Pet4You.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Pet4You
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Pet4YouDemoEntities db = new Pet4YouDemoEntities();
        public static User CurrentUser;
        public static ChattingModulePage ChatPage;
    }
}
