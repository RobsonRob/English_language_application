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

namespace Learn_English.Travel.Plane
{
    /// <summary>
    /// Interaction logic for PlaneWindow.xaml
    /// </summary>
    public partial class PlaneWindow : Window
    {
        public PlaneWindow()
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
            if (airport.Background == Brushes.Green && ticket.Background == Brushes.Green &&
                gates.Background == Brushes.Green && checkIn.Background == Brushes.Green &&
                informationBoard.Background == Brushes.Green && luggage.Background == Brushes.Green &&
                passport.Background == Brushes.Green)
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

        private void btnAirport_Click(object sender, RoutedEventArgs e)
        {
            if (airport.Text == "airport")
            {
                airport.Background = Brushes.Green;
            }
            else
            {
                airport.Background = Brushes.Red;
            }
        }

        private void btnTicket_Click(object sender, RoutedEventArgs e)
        {
            if (ticket.Text == "ticket")
            {
                ticket.Background = Brushes.Green;
            }
            else
            {
                ticket.Background = Brushes.Red;
            }
        }

        private void btnGates_Click(object sender, RoutedEventArgs e)
        {
            if (gates.Text == "gates")
            {
                gates.Background = Brushes.Green;
            }
            else
            {
                gates.Background = Brushes.Red;
            }
        }

        private void btnCheckIn_Click(object sender, RoutedEventArgs e)
        {
            if (checkIn.Text == "check in")
            {
                checkIn.Background = Brushes.Green;
            }
            else
            {
                checkIn.Background = Brushes.Red;
            }
        }

        private void btnInformationBoard_Click(object sender, RoutedEventArgs e)
        {
            if (informationBoard.Text == "information board")
            {
                informationBoard.Background = Brushes.Green;
            }
            else
            {
                informationBoard.Background = Brushes.Red;
            }
        }

        private void btnLuggage_Click(object sender, RoutedEventArgs e)
        {
            if (luggage.Text == "luggage")
            {
                luggage.Background = Brushes.Green;
            }
            else
            {
                luggage.Background = Brushes.Red;
            }
        }

        private void btnPassport_Click(object sender, RoutedEventArgs e)
        {
            if (passport.Text == "passport")
            {
                passport.Background = Brushes.Green;
            }
            else
            {
                passport.Background = Brushes.Red;
            }
        }

        private void btnCheckAirport_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                airport.Text = "airport";
                airport.Foreground = Brushes.LightGray;
            }
            else
            {
                airport.Clear();
            }
            a = !a;
        }

        private void btnCheckTicket_Click(object sender, RoutedEventArgs e)
        {
            if (b)
            {
                ticket.Text = "ticket";
                ticket.Foreground = Brushes.LightGray;
            }
            else
            {
                ticket.Clear();
            }
            b = !b;
        }

        private void btnCheckGates_Click(object sender, RoutedEventArgs e)
        {
            if (c)
            {
                gates.Text = "gates";
                gates.Foreground = Brushes.LightGray;
            }
            else
            {
                gates.Clear();
            }
            c = !c;
        }

        private void btnCheckCheckIn_Click(object sender, RoutedEventArgs e)
        {
            if (d)
            {
                checkIn.Text = "check in";
                checkIn.Foreground = Brushes.LightGray;
            }
            else
            {
                gates.Clear();
            }
            d = !d;
        }

        private void btnCheckInformationBoard_Click(object sender, RoutedEventArgs e)
        {
            if (ee)
            {
                informationBoard.Text = "information board";
                informationBoard.Foreground = Brushes.LightGray;
            }
            else
            {
                informationBoard.Clear();
            }
            ee = !ee;
        }

        private void btnCheckLuggage_Click(object sender, RoutedEventArgs e)
        {
            if (f)
            {
                luggage.Text = "luggage";
                luggage.Foreground = Brushes.LightGray;
            }
            else
            {
                luggage.Clear();
            }
            f = !f;
        }

        private void btnCheckPassport_Click(object sender, RoutedEventArgs e)
        {
            if (g)
            {
                passport.Text = "passport";
                passport.Foreground = Brushes.LightGray;
            }
            else
            {
                passport.Clear();
            }
            g = !g;
        }
    }
}
