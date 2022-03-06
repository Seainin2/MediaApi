using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class CreatingProperty
    {
        Guid Id { get; set; }
        String Name { get; set; }

        String Description { get; set; }

        List<Media> media { get; set; }

    }
}
