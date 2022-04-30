using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//in dbset
    public class Movie
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

        public String Description { get; set; }

        public int NumberofTimesSearched { get; set; }

        public int Length { get; set; }

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
}
