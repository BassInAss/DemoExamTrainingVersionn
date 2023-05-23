using System;
using System.Collections.Generic;

#nullable disable

namespace PreparingExmPrj.Model
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int IdOrder { get; set; }
        public int IdPoint { get; set; }
        public int TotalPrice { get; set; }
        public bool? Status { get; set; }

        public virtual Point IdPointNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
