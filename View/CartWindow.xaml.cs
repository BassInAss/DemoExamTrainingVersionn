using PreparingExmPrj.Model;
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

namespace PreparingExmPrj.View
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            cart_listbox.ItemsSource = CurrentCart.cartProducts;
            this.DataContext = CurrentCart.cartProducts;
            sum_label.Content = SumPrices().ToString();
            using (PreparingExamContext db = new())
            {
                points_combobox.ItemsSource = db.Points.ToList();
            }
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void makeOrder_button_Click(object sender, RoutedEventArgs e)
        {
            int index_order = 0;
            await using (PreparingExamContext db = new())
            {
                Model.Point point = (Model.Point)points_combobox.SelectedItem;
                db.Orders.Add(new Order() { IdPoint = point.IdPoint, Status = true, TotalPrice = int.Parse(sum_label.Content.ToString()) });
                await db.SaveChangesAsync();
                Order order = db.Orders.OrderBy(x => x.IdOrder).LastOrDefault();
                index_order = order.IdOrder;
                foreach (var cartProduct in CurrentCart.cartProducts)
                {
                    db.OrderProducts.Add(new OrderProduct() { IdOrder = index_order, IdProduct = cartProduct.IdProduct, Amount = cartProduct.Amount });
                }
                await db.SaveChangesAsync();
            }

            CheckWindow checkWindow = new CheckWindow(index_order);
            checkWindow.ShowDialog();
        }

        private void incAmount_button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartProduct selectedProduct = (CartProduct)cart_listbox.SelectedItem;
            CurrentCart.cartProducts.First(x => x.IdProduct == selectedProduct.IdProduct).Amount += 1;
            sum_label.Content = SumPrices().ToString();
        }

        private void decAmount_button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CartProduct selectedProduct = (CartProduct)cart_listbox.SelectedItem;
            if (selectedProduct.Amount > 1)
            {
                CurrentCart.cartProducts.First(x => x.IdProduct == selectedProduct.IdProduct).Amount -= 1;
            }
            else
            {
                CurrentCart.cartProducts.Remove(selectedProduct);
                cart_listbox.ItemsSource = CurrentCart.cartProducts;
                cart_listbox.Items.Refresh();
            }
            Application.Current.Properties["cart"] = CurrentCart.cartProducts;
            sum_label.Content = SumPrices().ToString();
            if (CurrentCart.cartProducts.Count == 0)
            {
                (Application.Current.MainWindow as MainWindow).cart_buttonBorder.Visibility = Visibility.Hidden;
                this.Close();
            }
        }

        private void deleteProduct_button_Click(object sender, RoutedEventArgs e)
        {
            CartProduct selectedProduct = (CartProduct)cart_listbox.SelectedItem;
            CurrentCart.cartProducts.Remove(selectedProduct);
            cart_listbox.ItemsSource = CurrentCart.cartProducts;
            cart_listbox.Items.Refresh();
            Application.Current.Properties["cart"] = CurrentCart.cartProducts;
            sum_label.Content = SumPrices().ToString();
            if (CurrentCart.cartProducts.Count == 0)
            {
                (Application.Current.MainWindow as MainWindow).cart_buttonBorder.Visibility = Visibility.Hidden;
                this.Close();
            }
        }
        private int SumPrices()
        {
            int sum = 0;
            foreach (var product in CurrentCart.cartProducts)
            {
                sum += product.Amount * product.Price;
            }
            return sum;
        }
    }
}
