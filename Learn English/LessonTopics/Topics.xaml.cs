using Learn_English.EverydayLife.Attractives;
using Learn_English.EverydayLife.Places;
using Learn_English.EverydayLife.Relax;
using Learn_English.EverydayLife.Views;
using Learn_English.Home.Bathroom;
using Learn_English.Home.Bedroom;
using Learn_English.Home.Kitchen;
using Learn_English.Home.LivingRoom;
using Learn_English.LoginPage;
using Learn_English.Travel.Bus;
using Learn_English.Travel.Car;
using Learn_English.Travel.Plane;
using Learn_English.Travel.Train;
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

namespace Learn_English.LessonTopics
{
    /// <summary>
    /// Interaction logic for Topics.xaml
    /// </summary>
    public partial class Topics : Window
    {
        public Topics()
        {

            InitializeComponent();
        }

        private void btnKitchen_Click(object sender, RoutedEventArgs e)
        {
            KitchenWindow kitchenWindow = new KitchenWindow();
            Opacity = 0.4;
            kitchenWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoomWindow livingRoomWindow = new LivingRoomWindow();
            Opacity = 0.4;
            livingRoomWindow.ShowDialog();
            Opacity= 1;
        }

        private void btnBedroom_Click(object sender, RoutedEventArgs e)
        {
            BedroomWindow bedroomWindow = new BedroomWindow();
            Opacity = 0.4;
            bedroomWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnBathroom_Click(object sender, RoutedEventArgs e)
        {
            BathroomWindow bathroomWindow = new BathroomWindow();
            Opacity = 0.4;
            bathroomWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnPlane_Click(object sender, RoutedEventArgs e)
        {
            PlaneWindow planeWindow = new PlaneWindow();
            Opacity = 0.4;
            planeWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnCar_Click(object sender, RoutedEventArgs e)
        {
            CarWindow carWindow = new CarWindow();
            Opacity = 0.4;
            carWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnBus_Click(object sender, RoutedEventArgs e)
        {
            BusWindow busWindow = new BusWindow();
            Opacity = 0.4;
            busWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnTrain_Click(object sender, RoutedEventArgs e)
        {
            TrainWindow trainWindow = new TrainWindow();
            Opacity = 0.4;
            trainWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnPlaces_Click(object sender, RoutedEventArgs e)
        {
            PlacesWindow placesWindow = new PlacesWindow();
            Opacity = 0.4;
            placesWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnAttractives_Click(object sender, RoutedEventArgs e)
        {
            AttractivesWindow attractivesWindow = new AttractivesWindow();
            Opacity = 0.4;
            attractivesWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnViews_Click(object sender, RoutedEventArgs e)
        {
            ViewsWindow viewsWindow = new ViewsWindow();
            Opacity = 0.4;
            viewsWindow.ShowDialog();
            Opacity = 1;
        }

        private void btnRelax_Click(object sender, RoutedEventArgs e)
        {
            RelaxWindow relaxWindow = new RelaxWindow();
            Opacity = 0.4;
            relaxWindow.ShowDialog();
            Opacity = 1;
        }
    }
}
