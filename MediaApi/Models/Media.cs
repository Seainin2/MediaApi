using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Media
    {
        Guid Id { get; set; }
        String Title { get; set; }

        DateTime ReleaseDate { get; set; }

        List<String> Genre { get; set; }

        List<String>Theme { get; set; }

        String Description { get; set; }

        int NumberofTimesSearched { get; set; }

        List<ReccomendingResource> Rating { get; set; }

        List<Seller> Seller { get; set; }

    }
}
