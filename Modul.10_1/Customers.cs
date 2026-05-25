using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq.Mapping;

namespace Modul._10_1
{
    [Table(Name = "Customers")]
    internal class Customers
    {
        [Column]
        public string CompanyName { get; set; }

        [Column]
        public string Address { get; set; }

        [Column]
        public string Phone { get; set; }

        [Column]
        public string Fax { get; set; }

        [Column]
        public string City { get; set; }
    }
}
