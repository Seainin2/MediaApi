using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApi.Models
{//in dbset
    public class UserReview
    {
        [Key]

        public Guid ReviewId { get; set; }
        [Required]
        public Guid MediaId { get; set; }
        [Required]
        [Column(TypeName="Date")]
        public DateTime DateCreated { get; set; }
        [Required]
        public String Username { get; set; }
        [Required]
        public int Rating { get; set; }

        public int UsefulReview { get; set; }


    }
}
