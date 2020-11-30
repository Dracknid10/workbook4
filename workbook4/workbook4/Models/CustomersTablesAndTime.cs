using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class CustomersTablesAndTime
    {
        public int CtatTableReference { get; set; }
        public int TableId { get; set; }
        public int CustomerId { get; set; }
        public int PartyNumber { get; set; }
        public TimeSpan TimeArrived { get; set; }
        public TimeSpan TimeDeparted { get; set; }
        public DateTime DateArrived { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual TableAndSeat Table { get; set; }
    }
}
