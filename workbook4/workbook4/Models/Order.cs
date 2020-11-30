using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
