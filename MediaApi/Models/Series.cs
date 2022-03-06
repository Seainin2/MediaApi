using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{//Collections of media i.e. Trilogies, games series, shows with multipy seasons
    public class Series
    {
        Guid Id { get; set; }
        String Name { get; set; }

        Boolean Finished { get; set; }

        List<Media> media { get; set; }

    }

    
}
