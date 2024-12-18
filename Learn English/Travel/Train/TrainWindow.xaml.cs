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

namespace Learn_English.Travel.Train
{
    /// <summary>
    /// Interaction logic for TrainWindow.xaml
    /// </summary>
    public partial class TrainWindow : Window
    {
        public TrainWindow()
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
            if (railwayStation.Background == Brushes.Green && meet.Background == Brushes.Green &&
                conductor.Background == Brushes.Green && railroadCrossing.Background == Brushes.Green &&
                tracks.Background == Brushes.Green && trainPlatform.Background == Brushes.Green &&
                wagon.Background == Brushes.Green)
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

        private void btnRailwayStation_Click(object sender, RoutedEventArgs e)
        {
            if (railwayStation.Text == "train station")
            {
                railwayStation.Background = Brushes.Green;
            }
            else
            {
                railwayStation.Background = Brushes.Red;
            }
        }

        private void btnMeet_Click(object sender, RoutedEventArgs e)
        {
            if (meet.Text == "meet")
            {
                meet.Background = Brushes.Green;
            }
            else
            {
                meet.Background = Brushes.Red;
            }
        }

        private void btnConductor_Click(object sender, RoutedEventArgs e)
        {
            if (conductor.Text == "conductor")
            {
                conductor.Background = Brushes.Green;
            }
            else
            {
                conductor.Background = Brushes.Red;
            }
        }

        private void btnRailroadCrossing_Click(object sender, RoutedEventArgs e)
        {
            if (railroadCrossing.Text == "level crossing")
            {
                railroadCrossing.Background = Brushes.Green;
            }
            else
            {
                railroadCrossing.Background = Brushes.Red;
            }
        }

        private void btnTracks_Click(object sender, RoutedEventArgs e)
        {
            if (tracks.Text == "tracks")
            {
                tracks.Background = Brushes.Green;
            }
            else
            {
                tracks.Background = Brushes.Red;
            }
        }

        private void btnTrainPlatform_Click(object sender, RoutedEventArgs e)
        {
            if (trainPlatform.Text == "platform")
            {
                trainPlatform.Background = Brushes.Green;
            }
            else
            {
                trainPlatform.Background = Brushes.Red;
            }
        }

        private void btnWagon_Click(object sender, RoutedEventArgs e)
        {
            if (wagon.Text == "wagon")
            {
                wagon.Background = Brushes.Green;
            }
            else
            {
                wagon.Background = Brushes.Red;
            }
        }

        private void btnCheckRailwayStation_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                railwayStation.Text = "train station";
                railwayStation.Foreground = Brushes.LightGray;
            }
            else
            {
                railwayStation.Clear();
            }
            a = !a;
        }

        private void btnCheckMeet_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                meet.Text = "meet";
                meet.Foreground = Brushes.LightGray;
            }
            else
            {
                meet.Clear();
            }
            b = !b;
        }

        private void btnCheckConductor_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                conductor.Text = "conductor";
                conductor.Foreground = Brushes.LightGray;
            }
            else
            {
                conductor.Clear();
            }
            c = !c;
        }

        private void btnCheckRailroadCrossing_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                railroadCrossing.Text = "level crossing";
                railroadCrossing.Foreground = Brushes.LightGray;
            }
            else
            {
                railroadCrossing.Clear();
            }
            d = !d;
        }

        private void btnCheckTracks_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                tracks.Text = "tracks";
                tracks.Foreground = Brushes.LightGray;
            }
            else
            {
                tracks.Clear();
            }
            ee = !ee;
        }

        private void btnCheckTrainPlatform_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                trainPlatform.Text = "platform";
                trainPlatform.Foreground = Brushes.LightGray;
            }
            else
            {
                trainPlatform.Clear();
            }
            f = !f;
        }

        private void btnCheckWagon_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                wagon.Text = "wagon";
                wagon.Foreground = Brushes.LightGray;
            }
            else
            {
                wagon.Clear();
            }
            g = !g;
        }
    }
}
