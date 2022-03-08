using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class ReccomendingResource
    {

        [Key]
        public Guid RatingId { get; set; }

        public Guid MediaId { get; set; }

        [Required]
        public String Name { get; set; }
        [Required]
        public String Rating { get; set; }
    }
}
