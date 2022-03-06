using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Book : Media
    {
        List<String> Author { get; set; }

        String Length { get; set; }

        List<String> OtherPerson { get; set; }

        int AmountOfTimesSearched { get; set; }
    }
}
