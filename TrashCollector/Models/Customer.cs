using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector.Models;
namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Address { get; set; }
        public string TrashPickUp { get; set; }
        public string ExtraPickUp { get; set; }
        public string TemporarySuspendPickUp { get; set; }

        [ForeignKey("IdnetityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
