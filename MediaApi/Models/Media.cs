using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Media
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        
        public List<Genre> Genre { get; set; }

        public List<Theme>Theme { get; set; }

        public String Description { get; set; }

        public int NumberofTimesSearched { get; set; }

        public List<ReccomendingResource> Rating { get; set; }

        public List<Seller> Seller { get; set; }


    }

    public class Genre { 
    
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public String GenreName { get; set; }
    
    }

    public class Theme
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public String ThemeName { get; set; }

    }
}
