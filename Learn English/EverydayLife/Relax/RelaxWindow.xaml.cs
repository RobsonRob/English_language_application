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

namespace Learn_English.EverydayLife.Relax
{
    /// <summary>
    /// Interaction logic for RelaxWindow.xaml
    /// </summary>
    public partial class RelaxWindow : Window
    {
        public RelaxWindow()
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
            if (book.Background == Brushes.Green && series.Background == Brushes.Green &&
                music.Background == Brushes.Green && bike.Background == Brushes.Green &&
                hammock.Background == Brushes.Green && running.Background == Brushes.Green &&
                forest.Background == Brushes.Green)
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

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            if(book.Text == "book")
            {
                book.Background = Brushes.Green;
            }
            else
            {
                book.Background = Brushes.Red;
            }
        }

        private void btnSeries_Click(object sender, RoutedEventArgs e)
        {
            if (series.Text == "series")
            {
                series.Background = Brushes.Green;
            }
            else
            {
                series.Background = Brushes.Red;
            }
        }

        private void btnMusic_Click(object sender, RoutedEventArgs e)
        {
            if (music.Text == "music")
            {
                music.Background = Brushes.Green;
            }
            else
            {
                music.Background = Brushes.Red;
            }
        }

        private void btnBike_Click(object sender, RoutedEventArgs e)
        {
            if (bike.Text == "bike")
            {
                bike.Background = Brushes.Green;
            }
            else
            {
                bike.Background = Brushes.Red;
            }
        }

        private void btnHammock_Click(object sender, RoutedEventArgs e)
        {
            if (hammock.Text == "hammock")
            {
                hammock.Background = Brushes.Green;
            }
            else
            {
                hammock.Background = Brushes.Red;
            }
        }

        private void btRunning_Click(object sender, RoutedEventArgs e)
        {
            if (running.Text == "running")
            {
                running.Background = Brushes.Green;
            }
            else
            {
                running.Background = Brushes.Red;
            }
        }

        private void btnForest_Click(object sender, RoutedEventArgs e)
        {
            if (forest.Text == "forest")
            {
                forest.Background = Brushes.Green;
            }
            else
            {
                forest.Background = Brushes.Red;
            }
        }

        private void btnCheckBook_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                book.Text = "book";
                book.Foreground = Brushes.LightGray;
            }
            else
            {
                book.Clear();
            }
            a = !a;
        }

        private void btnCheckSeries_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                series.Text = "series";
                series.Foreground = Brushes.LightGray;
            }
            else
            {
                series.Clear();
            }
            b = !b;
        }

        private void btnCheckMusic_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                music.Text = "music";
                music.Foreground = Brushes.LightGray;
            }
            else
            {
                music.Clear();
            }
            c = !c;
        }

        private void btnCheckBike_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                bike.Text = "bike";
                bike.Foreground = Brushes.LightGray;
            }
            else
            {
                bike.Clear();
            }
            d = !d;
        }

        private void btnCheckHammock_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                hammock.Text = "hammock";
                hammock.Foreground = Brushes.LightGray;
            }
            else
            {
                hammock.Clear();
            }
            ee = !ee;
        }

        private void btnCheckRunning_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                running.Text = "running";
                running.Foreground = Brushes.LightGray;
            }
            else
            {
                running.Clear();
            }
            f = !f;
        }

        private void btnCheckForest_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                forest.Text = "forest";
                forest.Foreground = Brushes.LightGray;
            }
            else
            {
                forest.Clear();
            }
            g = !g;
        }
    }
}
