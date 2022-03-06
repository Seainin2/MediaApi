using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//Collections of media i.e. Trilogies, games series, shows with multipy seasons
    public class Series
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public Boolean Finished { get; set; }

        public List<Media> Media { get; set; }

    }

    
}
