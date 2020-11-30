using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class AvailableTable
    {
        public int PubId { get; set; }
        public int TableId { get; set; }
        public bool AvailableSeats { get; set; }

        public virtual Pub Pub { get; set; }
        public virtual TableAndSeat Table { get; set; }
    }
}
