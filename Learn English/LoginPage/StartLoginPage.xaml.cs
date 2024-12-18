using Learn_English.LessonTopics;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Learn_English.LoginPage
{
    /// <summary>
    /// Interaction logic for StartLoginPage.xaml
    /// </summary>
    public partial class StartLoginPage : Page
    {
        public StartLoginPage()
        {
            InitializeComponent();
        }

        private bool choice = true;

        private void btnMale_Click(object sender, RoutedEventArgs e)
        {
            if (choice)
            {
                btnMale.Background = Brushes.Green;
                btnFemale.IsEnabled = false;
                btnFemale.Foreground = Brushes.Red;
                boxName.IsEnabled = true;
            }
            else
            {
                btnMale.Background = Brushes.Transparent;
                btnFemale.IsEnabled = true;
                btnFemale.Foreground = Brushes.LightBlue;
                boxName.IsEnabled = false;
            }
            choice = !choice;
        }

        private void btnFemale_Click(object sender, RoutedEventArgs e)
        {
            if (choice)
            {
                btnFemale.Background = Brushes.Green;
                btnMale.IsEnabled = false;
                btnMale.Foreground = Brushes.Red;
                boxName.IsEnabled = true;
            }
            else
            {
                btnFemale.Background = Brushes.Transparent;
                btnMale.IsEnabled = true;
                btnMale.Foreground = Brushes.PeachPuff;
                boxName.IsEnabled = false;
            }
            choice = !choice;
        }

        private void boxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(boxName.Text))
            {
                blockName.Visibility = Visibility.Visible;
                btnOK.IsEnabled = false;
            }
            else
            {
                blockName.Visibility = Visibility.Hidden; 
                btnOK.IsEnabled = true;
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
                Topics topics = new Topics();
                Opacity = 0.4;
                topics.ShowDialog();
                Opacity = 1;
        }
    }
}
