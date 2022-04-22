using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//in dbset
    public class Genre { 
    
        [Key]
        public Guid GenreId { get; set; }

        [Required]
        public String GenreName { get; set; }
    
    }
    //in dbset
    public class MediaGenre 
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid MediaId { get; set; }
        [Required]
        public Guid GenreId { get; set; }
    }
    //in dbset
    public class Theme
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String ThemeName { get; set; }

    }
    //in dbset
    public class MediaTheme
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid MediaId { get; set; }
        [Required]
        public Guid ThemeId { get; set; }
    }

}
