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
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }

        public String Description { get; set; }

        public List<Media> Media { get; set; }

    }
}
