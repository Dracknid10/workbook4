using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class VIdentifyPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public TimeSpan TimeArrived { get; set; }
        public TimeSpan TimeDeparted { get; set; }
        public DateTime DateArrived { get; set; }
    }
}
