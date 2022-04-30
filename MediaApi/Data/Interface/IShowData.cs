using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IShowData
    {
        List<Show> GetShows();

        Show GetShow(Guid id);

        Show AddShow(Show show);

        Show UpdateShow(Show show);

        Boolean DeleteShow(Guid id);
    }
}
