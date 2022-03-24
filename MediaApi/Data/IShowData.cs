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

        List<Show> GetShowsBySeriesId(Guid id);

        List<Show> GetShowsByCreatingPropertyId(Guid id);
    }
}
