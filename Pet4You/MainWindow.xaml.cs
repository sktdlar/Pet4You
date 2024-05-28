using Pet4You.Pages;
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

namespace Pet4You
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AuthPage());
        }

        public void AllClose()
        {
            HealthSp.Visibility = Visibility.Collapsed;
            ActivitySp.Visibility = Visibility.Collapsed;
            FoodSp.Visibility = Visibility.Collapsed;
            PetMedSp.Visibility = Visibility.Collapsed;
            Grid.SetRow(MainFrame, 1);
        }
        private void PartClick(object sender, RoutedEventArgs e)
        {
            AllClose();
            string text = (sender as Hyperlink).Name;
            if (text == "ActivityPart")
                ActivitySp.Visibility = Visibility.Visible;
            if (text == "HealthPart")
                HealthSp.Visibility = Visibility.Visible;
            if (text == "FoodPart")
                FoodSp.Visibility = Visibility.Visible;
            if (text == "PetMedPart")
                PetMedSp.Visibility = Visibility.Visible;
            Grid.SetRow(MainFrame, 2);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            AllClose();

        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GamePage());
            AllClose();
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SplashingPage());
            AllClose();
        }

        private void Hyperlink_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SplashingPage());
            AllClose();
        }

        private void Hyperlink_Click_4(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HealthPage());
            AllClose();
        }

        private void Hyperlink_Click_5(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VitaminsPage());
            AllClose();
        }

        private void Hyperlink_Click_6(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PathologyPage());
            AllClose();
        }

        private void Hyperlink_Click_7(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddHealthPage());
            AllClose();
        }

        private void Hyperlink_Click_8(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new KindsPage());
            AllClose();
        }

        private void Hyperlink_Click_9(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ComplementPage());
            AllClose();
        }

        private void Hyperlink_Click_10(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new FeedingPage());
            AllClose();
        }

        private void Hyperlink_Click_11(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListPage());
            AllClose();
        }

        private void Hyperlink_Click_12(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VaccinationsPage());
            AllClose();
        }

        private void Hyperlink_Click_13(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TreatmentPage());
            AllClose();
        }

        private void Hyperlink_Click_14(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProhibitionPage());
            AllClose();
        }

        private void Hyperlink_Click_15(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ChatPage());
            AllClose();
        }
    }
}

