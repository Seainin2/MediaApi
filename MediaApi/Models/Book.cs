using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Book : Media
    {
        [Required]
        public List<Person> Author { get; set; }

        public String Length { get; set; }

        public List<Person> OtherPerson { get; set; }

    }
}
