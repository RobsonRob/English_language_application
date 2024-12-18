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

namespace Learn_English.Home.Bathroom
{
    /// <summary>
    /// Interaction logic for BathroomWindow.xaml
    /// </summary>
    public partial class BathroomWindow : Window
    {
        public BathroomWindow()
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
            if (mirror.Background == Brushes.Green && bathtub.Background == Brushes.Green &&
                toothbrush.Background == Brushes.Green && sink.Background == Brushes.Green &&
                toilet.Background == Brushes.Green && toothpaste.Background == Brushes.Green &&
                towel.Background == Brushes.Green)
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
        private void btnMirror_Click(object sender, RoutedEventArgs e)
        {
            if(mirror.Text == "mirror")
            {
                mirror.Background = Brushes.Green;
            }
            else
            {
                mirror.Background= Brushes.Red;
            }
        }

        private void btnBathtub_Click(object sender, RoutedEventArgs e)
        {
            if (bathtub.Text == "bath")
            {
                bathtub.Background = Brushes.Green;
            }
            else
            {
                bathtub.Background = Brushes.Red;
            }
        }

        private void btnToothbrush_Click(object sender, RoutedEventArgs e)
        {
            if (toothbrush.Text == "toothbrush")
            {
                toothbrush.Background = Brushes.Green;
            }
            else
            {
                toothbrush.Background = Brushes.Red;
            }
        }

        private void btnSink_Click(object sender, RoutedEventArgs e)
        {
            if (sink.Text == "sink")
            {
                sink.Background = Brushes.Green;
            }
            else
            {
                sink.Background = Brushes.Red;
            }
        }

        private void btnToilet_Click(object sender, RoutedEventArgs e)
        {
            if (toilet.Text == "toilet")
            {
                toilet.Background = Brushes.Green;
            }
            else
            {
                toilet.Background = Brushes.Red;
            }
        }

        private void btnToothpaste_Click(object sender, RoutedEventArgs e)
        {
            if (toothpaste.Text == "toothpaste")
            {
                toothpaste.Background = Brushes.Green;
            }
            else
            {
                toothpaste.Background = Brushes.Red;
            }
        }

        private void btnTowel_Click(object sender, RoutedEventArgs e)
        {
            if (towel.Text == "towel")
            {
                towel.Background = Brushes.Green;
            }
            else
            {
                towel.Background = Brushes.Red;
            }
        }

        private void btnCheckMirror_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                mirror.Text = "mirror";
                mirror.Foreground = Brushes.LightGray;
            }
            else
            {
                mirror.Clear();
            }
            a = !a;
        }

        private void btnCheckBathtub_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                bathtub.Text = "bath";
                bathtub.Foreground = Brushes.LightGray;
            }
            else
            {
                bathtub.Clear();
            }
            b = !b;

        }

        private void btnCheckToothbrush_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                toothbrush.Text = "toothbrush";
                toothbrush.Foreground = Brushes.LightGray;
            }
            else
            {
                toothbrush.Clear();
            }
            c = !c;

        }

        private void btnCheckSink_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                sink.Text = "sink";
                sink.Foreground = Brushes.LightGray;
            }
            else
            {
                sink.Clear();
            }
            d = !d;
        }

        private void btnCheckToilet_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                toilet.Text = "toilet";
                toilet.Foreground = Brushes.LightGray;
            }
            else
            {
                toilet.Clear();
            }
            ee = !ee;
        }

        private void btnCheckToothpaste_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                toothpaste.Text = "toothpaste";
                toothpaste.Foreground = Brushes.LightGray;
            }
            else
            {
                toothpaste.Clear();
            }
            f = !f;
        }

        private void btnCheckTowel_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                towel.Text = "towel";
                towel.Foreground = Brushes.LightGray;
            }
            else
            {
                towel.Clear();
            }
            g = !g;
        }
    }
}
