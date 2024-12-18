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
using System.Windows.Shapes;

namespace Learn_English.EverydayLife.Views
{
    /// <summary>
    /// Interaction logic for ViewsWindow.xaml
    /// </summary>
    public partial class ViewsWindow : Window
    {
        public ViewsWindow()
        {
            InitializeComponent();
        }

        private bool a = true;
        private bool b = true;
        private bool c = true;
        private bool d = true;
        private bool ee = true;
        private bool f = true;
        private bool g = true;

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (mountains.Background == Brushes.Green && tower.Background == Brushes.Green &&
                trail.Background == Brushes.Green && backpack.Background == Brushes.Green &&
                binoculars.Background == Brushes.Green && sign.Background == Brushes.Green &&
                trekking.Background == Brushes.Green)
            {
                Close();
            }
            else
            {
                var result = MessageBox.Show("Do you want to end the lesson?", "Hi",
                     MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    Close();
                }
            }
        }

        private void btnMountains_Click(object sender, RoutedEventArgs e)
        {
            if (mountains.Text == "mountains")
            {
                mountains.Background = Brushes.Green;
            }
            else
            {
                mountains.Background = Brushes.Red;
            }
        }

        private void btnTower_Click(object sender, RoutedEventArgs e)
        {
            if (tower.Text == "tower")
            {
                tower.Background = Brushes.Green;
            }
            else
            {
                tower.Background = Brushes.Red;
            }
        }

        private void btnTrail_Click(object sender, RoutedEventArgs e)
        {
            if (trail.Text == "trail")
            {
                trail.Background = Brushes.Green;
            }
            else
            {
                trail.Background = Brushes.Red;
            }
        }

        private void btnBackpack_Click(object sender, RoutedEventArgs e)
        {
            if (backpack.Text == "backpack")
            {
                backpack.Background = Brushes.Green;
            }
            else
            {
                backpack.Background = Brushes.Red;
            }
        }

        private void btnBinoculars_Click(object sender, RoutedEventArgs e)
        {
            if (binoculars.Text == "binoculars")
            {
                binoculars.Background = Brushes.Green;
            }
            else
            {
                binoculars.Background = Brushes.Red;
            }
        }

        private void btSign_Click(object sender, RoutedEventArgs e)
        {
            if (sign.Text == "sign")
            {
                sign.Background = Brushes.Green;
            }
            else
            {
                sign.Background = Brushes.Red;
            }
        }

        private void btnTrekking_Click(object sender, RoutedEventArgs e)
        {
            if (trekking.Text == "trekking")
            {
                trekking.Background = Brushes.Green;
            }
            else
            {
                trekking.Background = Brushes.Red;
            }
        }

        private void btnCheckMountains_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                mountains.Text = "mountains";
                mountains.Foreground = Brushes.LightGray;
            }
            else
            {
                mountains.Clear();
            }
            a = !a;
        }

        private void btnCheckTower_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                tower.Text = "tower";
                tower.Foreground = Brushes.LightGray;
            }
            else
            {
                tower.Clear();
            }
            b = !b;
        }

        private void btnCheckTrail_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                trail.Text = "trail";
                trail.Foreground = Brushes.LightGray;
            }
            else
            {
                trail.Clear();
            }
            c = !c;
        }

        private void btnCheckBackpack_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                backpack.Text = "backpack";
                backpack.Foreground = Brushes.LightGray;
            }
            else
            {
                backpack.Clear();
            }
            d = !d;
        }

        private void btnCheckBinoculars_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                binoculars.Text = "binoculars";
                binoculars.Foreground = Brushes.LightGray;
            }
            else
            {
                binoculars.Clear();
            }
            ee = !ee;
        }

        private void btnCheckSign_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                sign.Text = "sign";
                sign.Foreground = Brushes.LightGray;
            }
            else
            {
                sign.Clear();
            }
            f = !f;
        }

        private void btnCheckTrekking_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                trekking.Text = "trekking";
                trekking.Foreground = Brushes.LightGray;
            }
            else
            {
                trekking.Clear();
            }
            g = !g;
        }
    }
}
