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
using System.Windows.Shapes;

namespace Learn_English.Home.LivingRoom
{
    /// <summary>
    /// Interaction logic for LivingRoomWindow.xaml
    /// </summary>
    public partial class LivingRoomWindow : Window
    {
        public LivingRoomWindow()
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
            if( WindowState == WindowState.Normal)
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
            if (carpet.Background == Brushes.Green && table.Background == Brushes.Green &&
                picture.Background == Brushes.Green && chair.Background == Brushes.Green &&
                clock.Background == Brushes.Green && sofa.Background == Brushes.Green &&
                tv.Background == Brushes.Green)
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

        private void btnCarpet_Click(object sender, RoutedEventArgs e)
        {
            if(carpet.Text == "carpet") 
            {
                carpet.Background = Brushes.Green;
            }
            else
            {
                carpet.Background = Brushes.Red;
            }
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            if (table.Text == "table")
            {
                table.Background = Brushes.Green;
            }
            else
            {
                table.Background = Brushes.Red;
            }
        }

        private void btnPicture_Click(object sender, RoutedEventArgs e)
        {
            if (picture.Text == "picture")
            {
                picture.Background = Brushes.Green;
            }
            else
            {
                picture.Background = Brushes.Red;
            }
        }
        private void btnChair_Click(object sender, RoutedEventArgs e)
        {
            if (chair.Text == "chair")
            {
                chair.Background = Brushes.Green;
            }
            else
            {
                chair.Background = Brushes.Red;
            }
        }

        private void btnClock_Click(object sender, RoutedEventArgs e)
        {
            if (clock.Text == "clock")
            {
                clock.Background = Brushes.Green;
            }
            else
            {
                clock.Background = Brushes.Red;
            }
        }

        private void btnSofa_Click(object sender, RoutedEventArgs e)
        {
            if (sofa.Text == "sofa")
            {
                sofa.Background = Brushes.Green;
            }
            else
            {
                sofa.Background = Brushes.Red;
            }
        }

        private void btnTv_Click(object sender, RoutedEventArgs e)
        {
            if (tv.Text == "tv")
            {
                tv.Background = Brushes.Green;
            }
            else
            {
                tv.Background = Brushes.Red;
            }
        }

        private void btnCheckCarpet_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                carpet.Text = "carpet";
                carpet.Foreground = Brushes.LightGray;
            }
            else
            {
                carpet.Clear();
            }
            a = !a;
        }

        private void btnCheckCTable_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                table.Text = "table";
                table.Foreground = Brushes.LightGray;
            }
            else
            {
                table.Clear();
            }
            b = !b;
        }

        private void btnCheckCPicture_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                picture.Text = "picture";
                picture.Foreground = Brushes.LightGray;
            }
            else
            {
                picture.Clear();
            }
            c = !c;
        }

        private void btnCheckChair_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                chair.Text = "chair";
                chair.Foreground = Brushes.LightGray;
            }
            else
            {
                chair.Clear();
            }
            d = !d;
        }

        private void btnCheckClock_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                clock.Text = "clock";
                clock.Foreground = Brushes.LightGray;
            }
            else
            {
                clock.Clear();
            }
            ee = !ee;
        }

        private void btnCheckSofa_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                sofa.Text = "sofa";
                sofa.Foreground = Brushes.LightGray;
            }
            else
            {
                sofa.Clear();
            }
            f = !f;
        }

        private void btnCheckTv_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                tv.Text = "tv";
                tv.Foreground = Brushes.LightGray;
            }
            else
            {
                tv.Clear();
            }
            g = !g;
        }
    }
}
