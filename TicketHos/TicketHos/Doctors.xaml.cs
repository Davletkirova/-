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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicketHos
{
    /// <summary>
    /// Логика взаимодействия для Doctors.xaml
    /// </summary>
    public partial class Doctors : Page
    {
        public Doctors()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NavigationService ns;
            //ns = NavigationService.GetNavigationService(this);
            //Ophthalmologist op = new Ophthalmologist();
            //ns.Navigate(op);
            //ns.Navigate(new Uri("Ophthalmologist.xaml", UriKind.RelativeOrAbsolute));
            this.NavigationService.Navigate(new Uri("Ophthalmologist.xaml", UriKind.RelativeOrAbsolute));


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Ultrasound.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LOR.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Therapist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Neurologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Gynecologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Dermatologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Cardiologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Psychiatrist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Endocrinologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Nutrionist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("GastroenterologAndNephorolog.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Narcologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pediatrician.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Dentist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Radiologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Urologist.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Surgeon.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
