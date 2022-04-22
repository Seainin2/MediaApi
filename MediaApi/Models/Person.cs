using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaApi.Models
{//in dbset
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }
        [Required]
        public String Name { get; set; }

        public String ImageName { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DOB { get; set; }

        [NotMapped]
        public String Position { get; set; }

    }
}
