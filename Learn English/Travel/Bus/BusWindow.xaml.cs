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

namespace Learn_English.Travel.Bus
{
    /// <summary>
    /// Interaction logic for BusWindow.xaml
    /// </summary>
    public partial class BusWindow : Window
    {
        public BusWindow()
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
            if (big.Background == Brushes.Green && windows.Background == Brushes.Green &&
                slowly.Background == Brushes.Green && busStop.Background == Brushes.Green &&
                busLights.Background == Brushes.Green && busMirror.Background == Brushes.Green &&
                trafficLights.Background == Brushes.Green)
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

        private void btnBig_Click(object sender, RoutedEventArgs e)
        {
            if (big.Text == "big")
            {
                big.Background = Brushes.Green;
            }
            else
            {
                big.Background = Brushes.Red;
            }
        }

        private void btnWindows_Click(object sender, RoutedEventArgs e)
        {
            if (windows.Text == "windows")
            {
                windows.Background = Brushes.Green;
            }
            else
            {
                windows.Background = Brushes.Red;
            }
        }

        private void btnSlowly_Click(object sender, RoutedEventArgs e)
        {
            if (slowly.Text == "slowly")
            {
                slowly.Background = Brushes.Green;
            }
            else
            {
                slowly.Background = Brushes.Red;
            }
        }

        private void btnBusStop_Click(object sender, RoutedEventArgs e)
        {
            if (busStop.Text == "bus stop")
            {
                busStop.Background = Brushes.Green;
            }
            else
            {
                busStop.Background = Brushes.Red;
            }
        }

        private void btnBusLights_Click(object sender, RoutedEventArgs e)
        {
            if (busLights.Text == "headlight")
            {
                busLights.Background = Brushes.Green;
            }
            else
            {
                busLights.Background = Brushes.Red;
            }
        }

        private void btnBusMirror_Click(object sender, RoutedEventArgs e)
        {
            if (busMirror.Text == "mirror")
            {
                busMirror.Background = Brushes.Green;
            }
            else
            {
                busMirror.Background = Brushes.Red;
            }
        }

        private void btnTrafficLights_Click(object sender, RoutedEventArgs e)
        {
            if (trafficLights.Text == "traffic lights")
            {
                trafficLights.Background = Brushes.Green;
            }
            else
            {
                trafficLights.Background = Brushes.Red;
            }
        }

        private void btnCheckBig_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                big.Text = "big";
                big.Foreground = Brushes.LightGray;
            }
            else
            {
                big.Clear();
            }
            a = !a;
        }

        private void btnCheckWindows_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                windows.Text = "windows";
                windows.Foreground = Brushes.LightGray;
            }
            else
            {
                windows.Clear();
            }
            b = !b;
        }

        private void btnCheckSlowly_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                slowly.Text = "slowly";
                slowly.Foreground = Brushes.LightGray;
            }
            else
            {
                slowly.Clear();
            }
            c = !c;
        }

        private void btnCheckBusStop_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                busStop.Text = "bus stop";
                busStop.Foreground = Brushes.LightGray;
            }
            else
            {
                busStop.Clear();
            }
            d = !d;
        }

        private void btnCheckBusLights_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                busLights.Text = "headlight";
                busLights.Foreground = Brushes.LightGray;
            }
            else
            {
                busLights.Clear();
            }
            ee = !ee;
        }

        private void btnCheckBusMirror_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                busMirror.Text = "mirror";
                busMirror.Foreground = Brushes.LightGray;
            }
            else
            {
                busMirror.Clear();
            }
            f = !f;
        }

        private void btnCheckTrafficLights_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                trafficLights.Text = "traffic lights";
                trafficLights.Foreground = Brushes.LightGray;
            }
            else
            {
                trafficLights.Clear();
            }
            g = !g;
        }
    }
}
