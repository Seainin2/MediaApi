using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MediaApi.Models
{
    public class Season : Media
    {
        public List<Person> Director { get; set; }

        public List<Episode> Episode { get; set; }

        public List<Person> Actor { get; set; }

        public List<Person> OtherPerson { get; set; }

    }

    public class Episode
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public int NumberOfEpisode { get; set; }
        public String Title { get; set; }

        public String Description { get; set; }

        public String Length { get; set; }

    }
}
