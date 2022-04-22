using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApi.Models
{//in dbset
    public class Show
    {
        [Key]
        public Guid MediaId { get; set; }

        public Guid SeriesId { get; set; }

        public Guid CreatingPropertyId { get; set; }

        [Required]

        public String MediaType { get; set; }

        [Required]

        public String Title { get; set; }

        public String ImageName { get; set; }

        [NotMapped]

        public List<Season> Seasons { get; set; }
    }
}
