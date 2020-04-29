using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class TrashPickUp
    {
        public Employee Employee { get; set; }
        public DateTime TrashPickUpDate { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
