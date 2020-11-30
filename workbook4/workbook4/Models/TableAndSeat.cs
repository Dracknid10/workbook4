using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class TableAndSeat
    {
        public TableAndSeat()
        {
            AvailableTables = new HashSet<AvailableTable>();
            CustomersTablesAndTimes = new HashSet<CustomersTablesAndTime>();
        }

        public int TableId { get; set; }
        public int Seats { get; set; }

        public virtual ICollection<AvailableTable> AvailableTables { get; set; }
        public virtual ICollection<CustomersTablesAndTime> CustomersTablesAndTimes { get; set; }
    }
}
