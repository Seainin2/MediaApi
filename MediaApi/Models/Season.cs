using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApi.Models
{//in dbset
    public class Season
    {
   
        [Key]
        public Guid SeasonId { get; set; }

        [Required]
        public Guid MediaId { get; set; }

        [Required]
        public String Title { get; set; }

        public String ImageName { get; set; }

        public String Description { get; set; }

        public int NumberofTimesSearched { get; set; }

        [NotMapped]

        public List<Episode> Episodes { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }

        [NotMapped]
        public List<Theme> Themes { get; set; }

        [NotMapped]
        public List<Genre> Genres { get; set; }

        [NotMapped]
        public List<Person> People { get; set; }

        [NotMapped]
        public List<ReccomendingResource> OfficialReviews { get; set; }

        [NotMapped]

        public List<UserReview> Reviews { get; set; }

    }
    //in dbset
    public class Episode
    {

        [Key]
        public Guid EpisodeId { get; set; }

        [Required]

        public Guid SeasonId { get; set; }
        [Required]
        public String Title { get; set; }

        public String Description { get; set; }

        public int Length { get; set; }

    }
}
