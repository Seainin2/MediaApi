using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IEpisodeData
    {

        List<Episode> GetEpisodes();

        Episode GetEpisode(Guid id);

        Episode AddEpisode(Episode episode);

        List<Episode> GetEpisodesBySeasonId(Guid id);

    }
}
