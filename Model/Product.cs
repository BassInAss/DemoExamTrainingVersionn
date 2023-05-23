using System;
using System.Collections.Generic;

#nullable disable

namespace PreparingExmPrj.Model
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
