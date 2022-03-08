using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Genre { 
    
    [Key]
    public Guid Id { get; set; }

    public Guid MediaId { get; set; }

        [Required]
    public String GenreName { get; set; }
    
    }

    public class Theme
    {

        [Key]
        public Guid Id { get; set; }

        public Guid MediaId { get; set; }

        [Required]
        public String ThemeName { get; set; }

    }
}
