using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Game : Media
    {
        [Required]
        public String Studio { get; set; }
        public List<MultiplayerOption> MultiplayerOption { get; set; }

        public List<Platform> Platform { get; set; }

    }

    public class MultiplayerOption
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String MultiplayerOptionType { get; set; }

    }

    public class Platform
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String PlatformName { get; set; }

    }
}
