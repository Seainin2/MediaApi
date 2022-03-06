using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Seller
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Name { get; set; }
        [Required]
        public String Price { get; set; }

        public Boolean Subscription { get; set; }
    }
}
