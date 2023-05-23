using PreparingExmPrj.Model;
using PreparingExmPrj.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace PreparingExmPrj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentCart.cartProducts = new();
            using (PreparingExamContext db = new())
            {
                product_listbox.ItemsSource = db.Products.ToList();
            }
        }

        private void cart_button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartWindow cartWindow = new();
            cartWindow.ShowDialog();
        }

        private void addProduct_button_Click(object sender, RoutedEventArgs e)
        {
            Product adding_product = (Product)product_listbox.SelectedItem;
            if (!CurrentCart.cartProducts.Select(x => x.IdProduct).Contains(adding_product.IdProduct))
            {
                CurrentCart.cartProducts.Add(new CartProduct() { IdProduct = adding_product.IdProduct, Discription = adding_product.Discription, Image = adding_product.Image, Name = adding_product.Name, Price = adding_product.Price, Amount = 1 });
            }
            else
            {
                CartProduct changed_product = CurrentCart.cartProducts.Where(x => x.IdProduct == adding_product.IdProduct).FirstOrDefault();
                CurrentCart.cartProducts.Where(x => x.IdProduct == changed_product.IdProduct).First().Amount += 1;
            }
            //Application.Current.Properties["cart"] = CurrentCart.cartProducts;
            cart_buttonBorder.Visibility = Visibility.Visible;
        }
    }
}
