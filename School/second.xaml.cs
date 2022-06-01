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
    /// Логика взаимодействия для second.xaml
    /// </summary>
    /// \]]
    
    public partial class second : Page
    {
   
        public second()
        {
            InitializeComponent();
            ProductGrid.ItemsSource = MainWindow.sessiya.Service.ToList();

        }
        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //NavigationService.Navigate(new AddEditService((sender as ListViewItem).DataContext as Product, userId1));
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (poiskDoc.Visibility == Visibility.Visible)
            {
                poiskDoc.Visibility = Visibility.Hidden;

            }

        }
    }
}
