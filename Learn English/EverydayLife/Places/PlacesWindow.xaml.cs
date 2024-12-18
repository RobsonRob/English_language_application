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

namespace Learn_English.EverydayLife.Places
{
    /// <summary>
    /// Interaction logic for PlacesWindow.xaml
    /// </summary>
    public partial class PlacesWindow : Window
    {
        public PlacesWindow()
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
            if (shop.Background == Brushes.Green && bakery.Background == Brushes.Green &&
                shoppingMall.Background == Brushes.Green && cinema.Background == Brushes.Green &&
                hospital.Background == Brushes.Green && mechanic.Background == Brushes.Green &&
                restaurant.Background == Brushes.Green)
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

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            if(shop.Text == "shop")
            {
                shop.Background = Brushes.Green;
            }
            else
            {
                shop.Background = Brushes.Red;
            }
        }

        private void btnBakery_Click(object sender, RoutedEventArgs e)
        {
            if (bakery.Text == "bakery")
            {
                bakery.Background = Brushes.Green;
            }
            else
            {
                bakery.Background = Brushes.Red;
            }
        }

        private void btnShoppingMall_Click(object sender, RoutedEventArgs e)
        {
            if (shoppingMall.Text == "shopping mall")
            {
                shoppingMall.Background = Brushes.Green;
            }
            else
            {
                shoppingMall.Background = Brushes.Red;
            }
        }

        private void btnCinema_Click(object sender, RoutedEventArgs e)
        {
            if (cinema.Text == "cinema")
            {
                cinema.Background = Brushes.Green;
            }
            else
            {
                cinema.Background = Brushes.Red;
            }
        }

        private void btnHospital_Click(object sender, RoutedEventArgs e)
        {
            if (hospital.Text == "hospital")
            {
                hospital.Background = Brushes.Green;
            }
            else
            {
                hospital.Background = Brushes.Red;
            }
        }

        private void btnMechanic_Click(object sender, RoutedEventArgs e)
        {
            if (mechanic.Text == "mechanic")
            {
                mechanic.Background = Brushes.Green;
            }
            else
            {
                mechanic.Background = Brushes.Red;
            }
        }

        private void btnRestaurant_Click(object sender, RoutedEventArgs e)
        {
            if (restaurant.Text == "restaurant")
            {
                restaurant.Background = Brushes.Green;
            }
            else
            {
                restaurant.Background = Brushes.Red;
            }
        }

        private void btnCheckShop_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                shop.Text = "shop";
                shop.Foreground = Brushes.LightGray;
            }
            else
            {
                shop.Clear();
            }
            a = !a;
        }

        private void btnCheckBakery_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                bakery.Text = "bakery";
                bakery.Foreground = Brushes.LightGray;
            }
            else
            {
                bakery.Clear();
            }
            b = !b;
        }

        private void btnCheckShoppingMall_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                shoppingMall.Text = "shopping mall";
                shoppingMall.Foreground = Brushes.LightGray;
            }
            else
            {
                shoppingMall.Clear();
            }
            c = !c;
        }

        private void btnCheckCinema_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                cinema.Text = "cinema";
                cinema.Foreground = Brushes.LightGray;
            }
            else
            {
                cinema.Clear();
            }
            d = !d;
        }

        private void btnCheckHospital_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                hospital.Text = "hospital";
                hospital.Foreground = Brushes.LightGray;
            }
            else
            {
                hospital.Clear();
            }
            ee = !ee;
        }

        private void btnCheckMechanic_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                mechanic.Text = "mechanic";
                mechanic.Foreground = Brushes.LightGray;
            }
            else
            {
                mechanic.Clear();
            }
            f = !f;
        }

        private void btnCheckRestaurant_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                restaurant.Text = "restaurant";
                restaurant.Foreground = Brushes.LightGray;
            }
            else
            {
                restaurant.Clear();
            }
            g = !g;
        }
    }
}
