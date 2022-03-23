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
        public Guid SellerId { get; set; }

        public Guid MediaId { get; set; }

        [Required]
        public String Name { get; set; }

        public String ImageName { get; set; }

        [Required]
        public String Price { get; set; }

        public Boolean Subscription { get; set; }
    }
}
