using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Game
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

        [Required]
        public String ReleaseDate { get; set; }

        public String Description { get; set; }

        public int NumberofTimesSearched { get; set; }

    }

    public class MultiplayerOption
    {

        [Key]
        public Guid MultiplayerOptionId { get; set; }

        public Guid GameId { get; set; }

        [Required]
        public String MultiplayerOptionType { get; set; }

    }

    public class Platform
    {

        [Key]
        public Guid PlatformId { get; set; }

        public Guid GameId { get; set; }

        [Required]
        public String PlatformName { get; set; }

    }
}
