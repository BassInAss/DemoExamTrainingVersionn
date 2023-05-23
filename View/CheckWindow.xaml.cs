using Microsoft.EntityFrameworkCore;
using PreparingExmPrj.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace PreparingExmPrj.View
{
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        private FixedDocumentSequence _document;
        private int indexOrder = new();
        public List<OrderProduct> current_orderproducts { get; set; }
        public Order current_order { get; set; }
        public CheckWindow(int index_order)
        {
            InitializeComponent();
            indexOrder = index_order;
            using (PreparingExamContext db = new())
            {
                db.Products.Load();
                db.Orders.Load();
                db.Points.Load();
                current_orderproducts = db.OrderProducts.Where(x => x.IdOrder == index_order).ToList();
                current_order = db.Orders.Where(x => x.IdOrder == index_order).FirstOrDefault();
                this.DataContext = this;
            }
        }
        public FixedDocumentSequence Document { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("printPreview.xps"))
            {
                File.Delete("printPreview.xps");
            }
            var xpsDocument = new XpsDocument("printPreview.xps", FileAccess.ReadWrite);
            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(xpsDocument);
            writer.Write(((IDocumentPaginatorSource)FD).DocumentPaginator);
            Document = xpsDocument.GetFixedDocumentSequence();
            xpsDocument.Close();
            var windows = new PrintWindow(Document, indexOrder);
            windows.ShowDialog();
        }
    }
}
