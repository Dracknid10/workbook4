using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class Pub
    {
        public Pub()
        {
            AvailableTables = new HashSet<AvailableTable>();
        }

        public int PubId { get; set; }
        public string PubName { get; set; }
        public int AmountOfTables { get; set; }

        public virtual ICollection<AvailableTable> AvailableTables { get; set; }
    }
}
