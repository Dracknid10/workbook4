using System;
using System.Collections.Generic;

#nullable disable

namespace workbook4.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomersTablesAndTimes = new HashSet<CustomersTablesAndTime>();
        }

        public int CustomerReferenceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public int NumberOfVisits { get; set; }

        public virtual ICollection<CustomersTablesAndTime> CustomersTablesAndTimes { get; set; }
    }
}
