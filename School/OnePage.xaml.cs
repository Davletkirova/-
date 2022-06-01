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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для OnePage.xaml
    /// </summary>
    public partial class OnePage : Page
    {
        public OnePage()
        {
            InitializeComponent();
        }
        private void Logn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Logn.Text == "Логин" && PassText.Text == "Пароль" || PassText.Text == "")
                Logn.Text = "";
            else if (Logn.Text == "Логин")
            {
                Logn.Text = "";
                PassText.Visibility = Visibility.Hidden;
                Pass.Visibility = Visibility.Visible;
            }
        }

        private void Logn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Logn.Text == "")
                Logn.Text = "Логин";
        }

        private void PassText_GotFocus(object sender, RoutedEventArgs e)
        {
            Pass.Focus();
            PassText.Visibility = Visibility.Hidden;
            Pass.Visibility = Visibility.Visible;
            Pass.Focus();
        }

        private void Pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Pass.Password == "")
            {
                Pass.Visibility = Visibility.Hidden;
                PassText.Visibility = Visibility.Visible;
                PassText.Text = "Пароль";
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SecondSecond());
        }
        private void Path_Click(object sender, MouseButtonEventArgs e)
        {
            //if (PassText.Visibility == Visibility.Visible)
            //{
            //    Pass.Password = PassText.Text;
            //    PassText.Visibility = Visibility.Hidden;
            //    Pass.Visibility = Visibility.Visible;
            //}
            //else
            //{
            //    PassText.Text = Pass.Password;
            //    PassText.Visibility = Visibility.Visible;
            //    Pass.Visibility = Visibility.Hidden;
            //}
            this.NavigationService.Navigate(new SecondSecond());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Registration());
        }
    }
}
