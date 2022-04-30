using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//Collections of media i.e. Trilogies, games series, shows with multipy seasons
    //in dbset
    public class Series
    {
        [Key]
        public Guid SeriesId { get; set; }

        [Required]

        public String MediaType { get; set; }

        [Required]
        public String Name { get; set; }

        public String Description { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        public String ImageName { get; set; }

        [Required]
        public Boolean Finished { get; set; }

        [NotMapped]

        public List<Object> Media { get; set; }

    }

    
}
