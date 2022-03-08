using System;
using System.ComponentModel.DataAnnotations;

namespace MediaApi.Models
{
    public class MediaPerson
    {
        [Key]
        public Guid Id { get; set; }

        public String Postion { get; set; }

        public Guid MediaId { get; set; }

        public Guid PersonId { get; set; }
    }
}
