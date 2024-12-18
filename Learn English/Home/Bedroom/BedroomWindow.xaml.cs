using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Claims;
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
using System.Windows.Shapes;

namespace Learn_English.Home.Bedroom
{
    /// <summary>
    /// Interaction logic for BedroomWindow.xaml
    /// </summary>
    public partial class BedroomWindow : Window
    {
        public BedroomWindow()
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
            if (bed.Background == Brushes.Green && nightTable.Background == Brushes.Green &&
                wardrobe.Background == Brushes.Green && bookshelf.Background == Brushes.Green &&
                alarmClock.Background == Brushes.Green && pillow.Background == Brushes.Green &&
                nightLamp.Background == Brushes.Green)
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
        private void btnBed_Click(object sender, RoutedEventArgs e)
        {
            if(bed.Text == "bed") 
            {
                bed.Background = Brushes.Green;
            }
            else
            {
                bed.Background = Brushes.Red;
            }
        }

        private void btnNightTable_Click(object sender, RoutedEventArgs e)
        {
            if(nightTable.Text == "night table")
            {
                nightTable.Background = Brushes.Green;
            }
            else
            {
                nightTable.Background = Brushes.Red;
            }
        }

        private void btnwardrobe_Click(object sender, RoutedEventArgs e)
        {
            if (wardrobe.Text == "wardrobe")
            {
                wardrobe.Background = Brushes.Green;
            }
            else
            {
                wardrobe.Background = Brushes.Red;
            }
        }

        private void btnBookshelf_Click(object sender, RoutedEventArgs e)
        {
            if (bookshelf.Text == "bookshelf")
            {
                bookshelf.Background = Brushes.Green;
            }
            else
            {
                bookshelf.Background = Brushes.Red;
            }
        }

        private void btnAlarmClock_Click(object sender, RoutedEventArgs e)
        {
            if (alarmClock.Text == "alarm clock")
            {
                alarmClock.Background = Brushes.Green;
            }
            else
            {
                alarmClock.Background = Brushes.Red;
            }
        }

        private void btnPillow_Click(object sender, RoutedEventArgs e)
        {
            if (pillow.Text == "pillow")
            {
                pillow.Background = Brushes.Green;
            }
            else
            {
                pillow.Background = Brushes.Red;
            }
        }

        private void btnNightLamp_Click(object sender, RoutedEventArgs e)
        {
            if (nightLamp.Text == "night lamp")
            {
                nightLamp.Background = Brushes.Green;
            }
            else
            {
                nightLamp.Background = Brushes.Red;
            }
        }

        private void btnCheckBed_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                bed.Text = "bed";
                bed.Foreground = Brushes.LightGray;
            }
            else
            {
                bed.Clear();
            }
            a = !a;
        }

        private void btnCheckNightTable_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                nightTable.Text = "night table";
                nightTable.Foreground = Brushes.LightGray;
            }
            else
            {
                nightTable.Clear();
            }
            b = !b;
        }

        private void btnCheckWardrobe_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                wardrobe.Text = "wardrobe";
                wardrobe.Foreground = Brushes.LightGray;
            }
            else
            {
                wardrobe.Clear();
            }
            c = !c;
        }

        private void btnCheckBookshelf_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                bookshelf.Text = "bookshelf";
                bookshelf.Foreground = Brushes.LightGray;
            }
            else
            {
                bookshelf.Clear();
            }
            d = !d;
        }

        private void btnCheckAlarmClock_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                alarmClock.Text = "alarm clock";
                alarmClock.Foreground = Brushes.LightGray;
            }
            else
            {
                alarmClock.Clear();
            }
            ee = !ee;
        }

        private void btnCheckPillow_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                pillow.Text = "pillow";
                pillow.Foreground = Brushes.LightGray;
            }
            else
            {
                pillow.Clear();
            }
            f = !f;
        }

        private void btnCheckNightLamp_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                nightLamp.Text = "night lamp";
                nightLamp.Foreground = Brushes.LightGray;
            }
            else
            {
                nightLamp.Clear();
            }
            g = !g;
        }
    }
}
