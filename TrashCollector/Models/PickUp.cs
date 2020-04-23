using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class PickUp
    {
        public int PickUpId { get; set; }
        public bool IsInvoiced { get; set; }
        public int DateCompleted { get; set; }

    }
}
