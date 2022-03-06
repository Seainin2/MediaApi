using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaApi.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public List<Media> Media { get; set; }
    }
}
