using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int ZipCodeId { get; set; }
    }
}
