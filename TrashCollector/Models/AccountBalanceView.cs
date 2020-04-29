using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class AccountBalanceView
    {
        public Customer Customer { get; set; }
        public double Balance { get; set; }
    }
}
