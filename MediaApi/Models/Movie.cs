using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Movie : Media
    {
        List<String> Director { get; set; }

        List<String> Actor { get; set; }

        String Length { get; set; }

        List<String> OtherPerson { get; set; }


    }
}
