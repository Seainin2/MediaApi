using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//in dbset
    public class CreatingProperty
    {
        [Key]
        public Guid CreatingPropertyId { get; set; }
        [Required]
        public String Name { get; set; }

        public String ImageName { get; set; }

        public String Description { get; set; }

        [NotMapped]
        public List<Object> Media { get; set; }

    }
}
