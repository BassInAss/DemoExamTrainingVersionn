using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для PrintWindow.xaml
    /// </summary>
    public partial class PrintWindow : Window
    {
        private FixedDocumentSequence _document;
        public List<OrderProduct> current_orderproducts { get; set; }
        public Order current_order { get; set; }
        public PrintWindow(FixedDocumentSequence document, int index_order)
        {
            using (PreparingExamContext db = new())
            {
                db.Products.Load();
                db.Orders.Load();
                db.Points.Load();
                current_orderproducts = db.OrderProducts.Where(x => x.IdOrder == index_order).ToList();
                current_order = db.Orders.Where(x => x.IdOrder == index_order).FirstOrDefault();
                this.DataContext = this;
            }

            _document = document;
            InitializeComponent();
            PreviewD.Document = document;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //print directly from the Xps file 
        }
    }
}
