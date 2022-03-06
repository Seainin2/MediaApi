using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Season : Media
    {
        List<String> Director { get; set; }

        List<Episode> Episode { get; set; }

        List<String> Actor { get; set; }

        List<String> OtherPerson { get; set; }
    }

    public class Episode { 
        
        int NumberOfEpisode { get; set; }
        String Title { get; set; }

        String Description { get; set; }

        String Length { get; set; }

    }
}
