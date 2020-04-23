using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class TrashCollection
    {
        public int TrashCollectionId {get; set;}
        public string PickUpDay { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
