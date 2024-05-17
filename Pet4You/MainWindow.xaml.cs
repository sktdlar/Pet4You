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
        }
    }

