using System;
using System.Collections.Generic;

#nullable disable

namespace PreparingExmPrj.Model
{
    public partial class OrderProduct
    {
        public int IdOrderProducts { get; set; }
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Amount { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
