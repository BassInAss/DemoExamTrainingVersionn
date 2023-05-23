using System;
using System.Collections.Generic;

#nullable disable

namespace PreparingExmPrj.Model
{
    public partial class Point
    {
        public Point()
        {
            Orders = new HashSet<Order>();
        }

        public int IdPoint { get; set; }
        public string Address { get; set; }
        public int DeliviryTime { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
