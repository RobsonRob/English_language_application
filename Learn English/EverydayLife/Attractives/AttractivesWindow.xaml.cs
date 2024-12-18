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

namespace Learn_English.EverydayLife.Attractives
{
    /// <summary>
    /// Interaction logic for AttractivesWindow.xaml
    /// </summary>
    public partial class AttractivesWindow : Window
    {
        public AttractivesWindow()
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
            if (japaneseGarden.Background == Brushes.Green && oldTown.Background == Brushes.Green &&
                localFood.Background == Brushes.Green && museum.Background == Brushes.Green &&
                amusementPark.Background == Brushes.Green && trampoline.Background == Brushes.Green &&
                zoo.Background == Brushes.Green)
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

        private void btnJapaneseGarden_Click(object sender, RoutedEventArgs e)
        {
            if (japaneseGarden.Text == "Japanese garden")
            {
                japaneseGarden.Background = Brushes.Green;
            }
            else
            {
                japaneseGarden.Background = Brushes.Red;
            }
        }

        private void btnOldTown_Click(object sender, RoutedEventArgs e)
        {
            if (oldTown.Text == "old town")
            {
                oldTown.Background = Brushes.Green;
            }
            else
            {
                oldTown.Background = Brushes.Red;
            }
        }

        private void btnLocalFood_Click(object sender, RoutedEventArgs e)
        {
            if (localFood.Text == "local food")
            {
                localFood.Background = Brushes.Green;
            }
            else
            {
                localFood.Background = Brushes.Red;
            }
        }

        private void btnMuseum_Click(object sender, RoutedEventArgs e)
        {
            if (museum.Text == "museum")
            {
                museum.Background = Brushes.Green;
            }
            else
            {
                museum.Background = Brushes.Red;
            }
        }

        private void btnAmusementPark_Click(object sender, RoutedEventArgs e)
        {
            if (amusementPark.Text == "amusement park")
            {
                amusementPark.Background = Brushes.Green;
            }
            else
            {
                amusementPark.Background = Brushes.Red;
            }
        }

        private void btnTrampoline_Click(object sender, RoutedEventArgs e)
        {
            if (trampoline.Text == "trampoline")
            {
                trampoline.Background = Brushes.Green;
            }
            else
            {
                trampoline.Background = Brushes.Red;
            }
        }

        private void btnZoo_Click(object sender, RoutedEventArgs e)
        {
            if (zoo.Text == "zoo")
            {
                zoo.Background = Brushes.Green;
            }
            else
            {
                zoo.Background = Brushes.Red;
            }
        }

        private void btnCheckJapaneseGarden_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                japaneseGarden.Text = "Japanese garden";
                japaneseGarden.Foreground = Brushes.LightGray;
            }
            else
            {
                japaneseGarden.Clear();
            }
            a = !a;
        }

        private void btnCheckOldTown_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                oldTown.Text = "old town";
                oldTown.Foreground = Brushes.LightGray;
            }
            else
            {
                oldTown.Clear();
            }
            b = !b;
        }

        private void btnCheckLocalFood_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                localFood.Text = "local food";
                localFood.Foreground = Brushes.LightGray;
            }
            else
            {
                localFood.Clear();
            }
            c = !c;
        }

        private void btnCheckMuseum_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                museum.Text = "museum";
                museum.Foreground = Brushes.LightGray;
            }
            else
            {
                museum.Clear();
            }
            d = !d;
        }

        private void btnCheckAmusementPark_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                amusementPark.Text = "amusement park";
                amusementPark.Foreground = Brushes.LightGray;
            }
            else
            {
                amusementPark.Clear();
            }
            ee = !ee;
        }

        private void btnCheckTrampoline_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                trampoline.Text = "trampoline";
                trampoline.Foreground = Brushes.LightGray;
            }
            else
            {
                trampoline.Clear();
            }
            f = !f;
        }

        private void btnCheckZoo_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                zoo.Text = "zoo";
                zoo.Foreground = Brushes.LightGray;
            }
            else
            {
                zoo.Clear();
            }
            g = !g;
        }
    }
}
