using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApi.Models
{
    public class Game : Media
    {

        String Studio { get; set; }

        List<String> MultiplayerOption { get; set; }

        List<String> Platform { get; set; }

    }
}
