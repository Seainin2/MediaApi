using System;
using System.ComponentModel.DataAnnotations;

namespace MediaApi.Models
{//in dbset
    public class MediaPerson
    {
        [Key]
        public Guid Id { get; set; }

        public String Postion { get; set; }
        [Required]
        public Guid MediaId { get; set; }
        [Required]
        public Guid PersonId { get; set; }
    }
}
