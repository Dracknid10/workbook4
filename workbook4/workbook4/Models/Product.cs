using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductDetails { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
