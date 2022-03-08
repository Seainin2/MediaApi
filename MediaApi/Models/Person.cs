using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaApi.Models
{
    public class Person
    {
        [Key]
        public Guid PersonId { get; set; }

        public string Name { get; set; }

        public String DOB { get; set; }

    }
}
