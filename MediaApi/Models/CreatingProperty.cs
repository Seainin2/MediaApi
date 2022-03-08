using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class CreatingProperty
    {
        [Key]
        public Guid CreatingPropertyId { get; set; }
        [Required]
        public String Name { get; set; }

        public String Description { get; set; }

    }
}
