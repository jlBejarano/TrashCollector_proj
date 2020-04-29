using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class CustomersEmployeeView
    {
        public Employee Employee { get; set; }
        public List<Customer> Customers { get; set; }
        public SelectList DaysToSelect { get; set; }
        public string DaySelect { get; set; }
        public bool Confirm { get; set; }
    }
}
