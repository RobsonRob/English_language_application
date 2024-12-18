using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
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

namespace Learn_English.Home.Kitchen
{
    /// <summary>
    /// Interaction logic for KitchenWindow.xaml
    /// </summary>
    public partial class KitchenWindow : Window
    {
        public KitchenWindow()
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
            if(WindowState == WindowState.Normal)
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
            if(cook.Background == Brushes.Green && pots.Background == Brushes.Green && 
                vegetables.Background == Brushes.Green && pan.Background == Brushes.Green &&
                plate.Background == Brushes.Green && fork.Background == Brushes.Green && 
                spoon.Background == Brushes.Green)
            {
                Close();
            }
            else
            {
                var result = MessageBox.Show("Do you want to end the lesson?", "Hi",
                     MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    Close();
                }
            }
        }

        private void btnCook_Click(object sender, RoutedEventArgs e)
        {
            if (cook.Text == "to cook")
            {
                cook.Background = Brushes.Green;
            }
            else
            {
                cook.Background = Brushes.Red;
            }
        }

        private void btnPots_Click(object sender, RoutedEventArgs e)
        {
            if (pots.Text == "pots")
            {
                pots.Background = Brushes.Green;
            }
            else
            {
                pots.Background = Brushes.Red;
            }
        }

        private void btnVegetables_Click(object sender, RoutedEventArgs e)
        {
            if (vegetables.Text == "green vegetables")
            {
                vegetables.Background = Brushes.Green;
            }
            else
            {
                vegetables.Background = Brushes.Red;
            }
        }

        private void btnPan_Click(object sender, RoutedEventArgs e)
        {
            if (pan.Text == "pan")
            {
                pan.Background = Brushes.Green;
            }
            else
            {
                pan.Background = Brushes.Red;
            }
        }

        private void btnPlate_Click(object sender, RoutedEventArgs e)
        {
            if (plate.Text == "plate")
            {
                plate.Background = Brushes.Green;
            }
            else
            {
                plate.Background = Brushes.Red;
            }
        }

        private void btnFork_Click(object sender, RoutedEventArgs e)
        {
            if (fork.Text == "fork")
            {
                fork.Background = Brushes.Green;
            }
            else
            {
                fork.Background = Brushes.Red;
            }
        }

        private void btnSpoon_Click(object sender, RoutedEventArgs e)
        {
            if (spoon.Text == "spoon")
            {
                spoon.Background = Brushes.Green;
            }
            else
            {
                spoon.Background = Brushes.Red;
            }
        }

        private void btnCheckCook_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                cook.Text = "to cook";
                cook.Foreground = Brushes.LightGray;
            }
            else
            {
                cook.Clear();
            }
            a = !a;
        }

        private void btnCheckPots_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                pots.Text = "pots";
                pots.Foreground = Brushes.LightGray;
            }
            else
            {
                pots.Clear();
            }
            b = !b;
        }

        private void btnCheckVegetables_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                vegetables.Text = "green vegetables";
                vegetables.Foreground = Brushes.LightGray;
            }
            else
            {
                vegetables.Clear();
            }
            c = !c;
        }

        private void btnCheckPan_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                pan.Text = "pan";
                pan.Foreground = Brushes.LightGray;
            }
            else
            {
                pan.Clear();
            }
            d = !d;
        }
        private void btnCheckPlate_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                plate.Text = "plate";
                plate.Foreground = Brushes.LightGray;
            }
            else
            {
                plate.Clear();
            }
            ee = !ee;
        }

        private void btnCheckFork_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                fork.Text = "fork";
                fork.Foreground = Brushes.LightGray;
            }
            else
            {
                fork.Clear();
            }
            f = !f;
        }

        private void btnCheckSpoon_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                spoon.Text = "spoon";
                spoon.Foreground = Brushes.LightGray;
            }
            else
            {
                spoon.Clear();
            }
            g = !g;
        }
    }
}
