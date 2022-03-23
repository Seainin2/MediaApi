using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApi.Models
{
    public class Season
    {
        [Key]
        public Guid MediaId { get; set; }

        public Guid SeriesId { get; set; }

        public Guid CreatingPropertyId { get; set; }

        [Required]
        public String Title { get; set; }

        public String ImageName { get; set; }

        [Required]
        public String ReleaseDate { get; set; }

        public String Description { get; set; }

        public int NumberofTimesSearched { get; set; }

        [NotMapped]

        public List<Episode> Episodes { get; set; }

    }

    public class Episode
    {

        [Key]
        public Guid EpisodeId { get; set; }

        [Required]

        public Guid SeasonId { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public int Length { get; set; }

    }
}
