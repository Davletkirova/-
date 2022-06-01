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
    /// Логика взаимодействия для AddEditService.xaml
    /// </summary>
    public partial class AddEditService : Page
    {
        public AddEditService()
        {
            InitializeComponent();
        }
        private void AddEdit()
        {
            //if (newProduct != null)
            //{
            //    //AddEd.Text = "Редактирование продукта";
            //    //IdProduct.Visibility = Visibility.Visible;
            //    //IdentProduct.Visibility = Visibility.Visible;
            //    //NameProduct.Text = newProduct.Name;
            //    //Image img = new Image();
            //    //byte[] imageData = newProduct.Photo;
            //    //MemoryStream stream = new MemoryStream(imageData);
            //    //img.Source = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            //    //ProductPhoto.Source = img.Source;
            //    //CommentProduct.Text = newProduct.Comment;


            //    //TypeUnitBox.SelectedItem = newProduct.TypeUnit.Name;


            //}
            //else if (newProduct == null)
            //{
            //    IdProduct.Visibility = Visibility.Hidden;
            //    IdentProduct.Visibility = Visibility.Hidden;
            //    AddEd.Text = "Добавление продукта";
            //    NameProduct.Text = "Название";
            //    ProductPhotoName.Text = "Картинка продукта";
            //    CommentProduct.Text = "Комментарий";


            //    TypeUnitBox.SelectedItem = "Единица измерения";

            //}
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //if (newProduct == null)
            //{
            //    Country countr = new Country();
            //    Product prod = new Product();
            //    prod.Name = NameProduct.Text;
            //    prod.Photo = File.ReadAllBytes(photoProduct);
            //    prod.Comment = CommentProduct.Text;
            //    prod.DataAdd = DateTime.Now;
            //    prod.TypeUnitId = (TypeUnitBox.SelectedItem as TypeUnit).Id;
            //    prod.UserId = userId2;
            //    prod.ProductCountry.Add(new ProductCountry
            //    {
            //        Country = CountryBox.SelectedItem as Country
            //    });
            //    prod.DataAdd = DateTime.Now;
            //    MainWindow.DB.Product.Add(prod);
            //}
            //else
            //{
            //    newProduct.Name = NameProduct.Text;
            //    if (photoProduct != null)
            //        newProduct.Photo = File.ReadAllBytes(photoProduct);
            //    newProduct.Comment = CommentProduct.Text;
            //    newProduct.DataAdd = DateTime.Now;

            //    newProduct.TypeUnitId = (TypeUnitBox.SelectedItem as TypeUnit).Id;
            //    newProduct.UserId = userId2;
            //    newProduct.ProductCountry.Add(new ProductCountry
            //    {
            //        Country = CountryBox.SelectedItem as Country
            //    });
            //}
            //MainWindow.DB.SaveChanges();
            //MessageBox.Show("Информация успешно сохранена!");

            //NavigationService.GoBack();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Title = "Выберите картинку";
            //openFileDialog.Filter = "Image file (*.png;*.jpg)|*.png;*.jpeg";
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    ProductPhoto.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            //}
            //photoProduct = openFileDialog.FileName;
            //ProductPhotoName.Text = photoProduct;
            //ProductPhotoName.Opacity = 1;
        }

        private void NameProduct_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameProduct.Text == "Название")
                NameProduct.Text = "";
        }

        private void NameProduct_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameProduct.Text == "")
                NameProduct.Text = "Название";
        }

        private void CommentProduct_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CommentProduct.Text == "Комментарий")
                CommentProduct.Text = "";
        }

        private void CommentProduct_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CommentProduct.Text == "")
                CommentProduct.Text = "Комментарий";
        }




        private void NameProduct_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //string Symbol = e.Text.ToString();

            //if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[-]|[ ]").Success)
            //{
            //    e.Handled = true;
            //}
        }

        private void CommentProduct_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //    string Symbol = e.Text.ToString();

            //    if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[-]|[ ]").Success)
            //    {
            //        e.Handled = true;
            //    }
            //}

            //private void CountryBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            //{

        }
    }
}
