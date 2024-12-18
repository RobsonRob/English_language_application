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

namespace Learn_English.Travel.Car
{
    /// <summary>
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        public CarWindow()
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
            if (small.Background == Brushes.Green && navigation.Background == Brushes.Green &&
                road.Background == Brushes.Green && carDoor.Background == Brushes.Green &&
                carSeat.Background == Brushes.Green && carWheel.Background == Brushes.Green &&
                steeringWheel.Background == Brushes.Green)
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

        private void btnSmall_Click(object sender, RoutedEventArgs e)
        {
            if (small.Text == "small")
            {
                small.Background = Brushes.Green;
            }
            else
            {
                small.Background = Brushes.Red;
            }
        }

        private void btnNavigation_Click(object sender, RoutedEventArgs e)
        {
            if (navigation.Text == "navigation")
            {
                navigation.Background = Brushes.Green;
            }
            else
            {
                navigation.Background = Brushes.Red;
            }
        }

        private void btnRoad_Click(object sender, RoutedEventArgs e)
        {
            if (road.Text == "road")
            {
                road.Background = Brushes.Green;
            }
            else
            {
                road.Background = Brushes.Red;
            }
        }

        private void btnCarDoor_Click(object sender, RoutedEventArgs e)
        {
            if (carDoor.Text == "door")
            {
                carDoor.Background = Brushes.Green;
            }
            else
            {
                carDoor.Background = Brushes.Red;
            }
        }

        private void btnCarSeat_Click(object sender, RoutedEventArgs e)
        {
            if (carSeat.Text == "seat")
            {
                carSeat.Background = Brushes.Green;
            }
            else
            {
                carSeat.Background = Brushes.Red;
            }
        }

        private void btnCarWheel_Click(object sender, RoutedEventArgs e)
        {
            if (carWheel.Text == "wheel")
            {
                carWheel.Background = Brushes.Green;
            }
            else
            {
                carWheel.Background = Brushes.Red;
            }
        }

        private void btnSteeringWheel_Click(object sender, RoutedEventArgs e)
        {
            if (steeringWheel.Text == "steering wheel")
            {
                steeringWheel.Background = Brushes.Green;
            }
            else
            {
                steeringWheel.Background = Brushes.Red;
            }
        }

        private void btnCheckSmall_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                small.Text = "small";
                small.Foreground = Brushes.LightGray;
            }
            else
            {
                small.Clear();
            }
            a = !a;
        }

        private void btnCheckNavigation_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                navigation.Text = "navigation";
                navigation.Foreground = Brushes.LightGray;
            }
            else
            {
                navigation.Clear();
            }
            b = !b;
        }

        private void btnCheckRoad_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                road.Text = "road";
                road.Foreground = Brushes.LightGray;
            }
            else
            {
                road.Clear();
            }
            c = !c;
        }

        private void btnCheckCarDoor_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                carDoor.Text = "door";
                carDoor.Foreground = Brushes.LightGray;
            }
            else
            {
                carDoor.Clear();
            }
            d = !d;
        }

        private void btnCheckCarSeat_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                carSeat.Text = "seat";
                carSeat.Foreground = Brushes.LightGray;
            }
            else
            {
                carSeat.Clear();
            }
            ee = !ee;
        }

        private void btnCheckCarWheel_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                carWheel.Text = "wheel";
                carWheel.Foreground = Brushes.LightGray;
            }
            else
            {
                carWheel.Clear();
            }
            f = !f;
        }

        private void btnCheckSteeringWheel_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                steeringWheel.Text = "steering wheel";
                steeringWheel.Foreground = Brushes.LightGray;
            }
            else
            {
                steeringWheel.Clear();
            }
            g = !g;
        }
    }
}
